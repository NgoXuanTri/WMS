using RMS.ViewModel;
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

namespace RMS.View
{
    /// <summary>
    /// Interaction logic for frmReceivingDocuments.xaml
    /// </summary>
    public partial class frmReceivingDocuments : Window
    {
        public frmReceivingDocuments()
        {
            InitializeComponent();
            RecevingDocumentsViewModel context = new RecevingDocumentsViewModel();
            this.DataContext = context;
        }
    }
}
