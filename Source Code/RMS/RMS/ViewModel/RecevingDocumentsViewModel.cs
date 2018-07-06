using RMS.Common;
using RMS.DA;
using RMS.Report;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DevExpress.XtraReports;
using DevExpress.Xpf.Printing;

namespace RMS.ViewModel
{
    public class RecevingDocumentsViewModel : ViewModelBase
    {
        private ObservableCollection<DSReceivingOrder> order;
        private ObservableCollection<DSROCarton> orderDetails;
        private ObservableCollection<ViewCustomer> customers;
        private ICommand updateCommand;
        private ICommand insertCommand;
        private ICommand deleteCommand;
        private ICommand operationCommand;
        private ICommand addNewOrderCommand;
        private ICommand showReportCommand;
        private int roID = 0;

        public ObservableCollection<DSReceivingOrder> Orders
        {
            get
            {
                return this.order;
            }
            set
            {
                this.order = value;
                this.OnPropertyChanged("Orders");
            }
        }
        public ObservableCollection<DSROCarton> OrderDetails
        {
            get
            {
                return this.orderDetails;
            }
            set
            {
                this.orderDetails = value;
                this.OnPropertyChanged("OrderDetails");
            }
        }
        public ObservableCollection<ViewCustomer> Customers
        {
            get
            {
                return this.customers;
            }
            set
            {
                this.customers = value;
                this.OnPropertyChanged("Customers");
            }
        }
        public ICommand UpdateCommand
        {
            get
            {
                return this.updateCommand;
            }
            set
            {
                this.updateCommand = value;
            }
        }
        public ICommand AddNewOrderCommand
        {
            get
            {
                return this.addNewOrderCommand;
            }
            set
            {
                this.addNewOrderCommand = value;
            }
        }
        public ICommand InsertCommand
        {
            get
            {
                return insertCommand;
            }
            set
            {
                this.insertCommand = value;
            }
        }
        public ICommand DeleteCommand
        {
            get
            {
                return deleteCommand;
            }
            set
            {
                deleteCommand = value;
            }
        }
        public ICommand OperationCommand
        {
            get
            {
                return this.operationCommand;
            }
            set
            {
                this.operationCommand = value;
            }
        }
        public ICommand ShowReportCommand
        {
            get
            {
                return this.showReportCommand;
            }
            set
            {
                this.showReportCommand = value;
            }
        }

        public int CustomerIDSelected
        {
            get; set;
        }
        public string Remark
        {
            get; set;
        }
        public int OrderID
        {
            get;set;
        }

        private void OnUpdate()
        {
            var dataSourceUpdate = this.Orders.Where(c => c.DSReceivingOrderID > 0).ToList();
            DataProcess<DSReceivingOrder> categoryDA = new DataProcess<DSReceivingOrder>();
            categoryDA.Update(dataSourceUpdate.ToArray());
        }

        private void OnInsert()
        {
            var dataSourceUpdate = this.Orders.Where(c => c.DSReceivingOrderID <= 0).ToList();
            DataProcess<DSReceivingOrder> categoryDA = new DataProcess<DSReceivingOrder>();
            categoryDA.Insert(dataSourceUpdate.ToArray());
        }

        private void OnDelete()
        {
            var dataSourceUpdate = this.Orders.Where(c => c.DSReceivingOrderID <= 0).ToList();
            DataProcess<DSReceivingOrder> categoryDA = new DataProcess<DSReceivingOrder>();
            categoryDA.Insert(dataSourceUpdate.ToArray());
        }

        private void AddNewOrder()
        {
            DSReceivingOrder newOrder = new DSReceivingOrder();
            newOrder.DSCustomerID = this.CustomerIDSelected;
            newOrder.DSSpecialRequirement = this.Remark;
            newOrder.DSReceivingOrderDate = DateTime.Now;
            newOrder.ServiceID = 1;
            DataProcess<DSReceivingOrder> categoryDA = new DataProcess<DSReceivingOrder>();
            categoryDA.Insert(newOrder);
        }

        private void ShowNoteReport()
        {
            rptNotes rpt = new rptNotes();
            DataProcess<SP_DSReceivingAdvice_Note_Result> process = new DataProcess<SP_DSReceivingAdvice_Note_Result>();
            rpt.DataSource = process.Executing("SP_DSReceivingAdvice_Note @DSROID={0}", this.OrderID);
            rpt.Parameters["parameter1"].Value = this.OrderID;
            frmReportPreview pt = new frmReportPreview(rpt);
            pt.ShowDialog();
        }

        private bool CanUpdate()
        {
            return true;
        }

        public RecevingDocumentsViewModel()
        {
            // Init command
            this.insertCommand = new DelegateCommand(OnInsert, CanUpdate);
            this.updateCommand = new DelegateCommand(OnUpdate, CanUpdate);
            this.deleteCommand = new DelegateCommand(OnDelete, CanUpdate);
            this.addNewOrderCommand = new DelegateCommand(AddNewOrder, CanUpdate);
            this.showReportCommand = new DelegateCommand(ShowNoteReport, CanUpdate);
            this.loadData();
        }
        private void loadData()
        {
            // Load all customer 
            DataProcess<ViewCustomer> customerDA = new DataProcess<ViewCustomer>();
            var customerSource = new ObservableCollection<ViewCustomer>(customerDA.Select());
            this.Customers = customerSource;

            DataProcess<DSReceivingOrder> orderDA = new DataProcess<DSReceivingOrder>();
            DateTime limitedDate = DateTime.Now.AddDays(-7);
            var dataSource = new ObservableCollection<DSReceivingOrder>(orderDA.Select(r => r.DSReceivingCreatedTime >= limitedDate));
            this.Orders = dataSource;

            DataProcess<DSROCarton> orderDetailDA = new DataProcess<DSROCarton>();
            this.OrderID = dataSource.FirstOrDefault().DSReceivingOrderID;
            var dataDetailSource = new ObservableCollection<DSROCarton>(orderDetailDA.Select(cr => cr.DSROID == this.OrderID));
            this.OrderDetails = dataDetailSource;
        }
    }
}
