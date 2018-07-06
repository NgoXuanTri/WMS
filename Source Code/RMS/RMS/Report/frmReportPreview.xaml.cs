using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RMS.Report
{
    /// <summary>
    /// Interaction logic for frmReportPreview.xaml
    /// </summary>
    public partial class frmReportPreview : Window
    {
        public frmReportPreview(DevExpress.XtraReports.UI.XtraReport rpt)
        {
            InitializeComponent();
            this.documentView1.DocumentSource = rpt;
            rpt.CreateDocument();
        }
    }
}
