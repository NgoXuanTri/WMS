using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.DA
{
    public class FileProcess
    {
        // Declare log
        private static readonly ILog log = LogManager.GetLogger(typeof(FileProcess));

        /// <summary>
        /// Insert table into DB by table Name
        /// </summary>
        /// <param name="dt">DataTable</param>
        /// <param name="tableName">string</param>
        /// <returns>int</returns>
        public static int InsertFile(DataTable dt, string tableName)
        {
            using (var context = new DocumentDBEntities())
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        using (var bulkInsert = new SqlBulkCopy(context.Database.Connection.ConnectionString))
                        {
                            bulkInsert.DestinationTableName = tableName;
                            bulkInsert.WriteToServer(dt);
                        }

                        dbContextTransaction.Commit();
                        return 0;
                    }
                    catch (Exception ex)
                    {
                        log.ErrorFormat("==> InsertFile is error, tableName=[{0}]", tableName);
                        log.ErrorFormat("Error is unexpected message=[{0}],\n InnerException=[{1}],\n StackTrace=[{2}]", ex.Message, ex.InnerException, ex.StackTrace);
                        dbContextTransaction.Rollback();
                        return -1;
                    }
                }
            }
        }

        /// <summary>
        /// Load data by query clause to dataTable
        /// </summary>
        /// <param name="commandText">string</param>
        /// <returns>DataTable</returns>
        public static DataTable LoadTable(string commandText)
        {
            using (var context = new DocumentDBEntities())
            {
                try
                {
                    using (var connection = context.Database.Connection)
                    {
                        using (var command = connection.CreateCommand())
                        {
                            command.CommandText = commandText;
                            connection.Open();
                            using (var reader = command.ExecuteReader(CommandBehavior.SequentialAccess))
                            {
                                using (var tbResult = new DataTable())
                                {
                                    tbResult.Load(reader);
                                    return tbResult;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    log.ErrorFormat("==> LoadTable is error, CommandText=[{0}]", commandText);
                    log.ErrorFormat("Error is unexpected message=[{0}],\n InnerException=[{1}],\n StackTrace=[{2}]", ex.Message, ex.InnerException, ex.StackTrace);
                    return null;
                }
            }
        }
    }
}
