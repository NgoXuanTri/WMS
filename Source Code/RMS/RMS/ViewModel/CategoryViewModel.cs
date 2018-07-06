using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.DA;
using System.Windows.Input;
using RMS.Common;
using System.Windows.Media;
using System.Windows;
using RMS.View;

namespace RMS.ViewModel
{
    public class CategoryViewModel : ViewModelBase
    {
        private ObservableCollection<Category> _category;
        private ICommand updateCommand;
        private ICommand insertCommand;
        private ICommand deleteCommand;
        private ICommand operationCommand;
        public CategoryViewModel()
        {
            this.LoadCategory();
        }

        public ObservableCollection<Category> Categorys
        {
            get
            {
                return this._category;
            }
            set
            {
                this._category = value;
                this.OnPropertyChanged("Categorys");
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

        private void OnUpdate()
        {
            var dataSourceUpdate = this.Categorys.Where(c => c.CategoryID > 0).ToList();
            DataProcess<Category> categoryDA = new DataProcess<Category>();
            categoryDA.Update(dataSourceUpdate.ToArray());
        }

        private void OnInsert()
        {
            var dataSourceUpdate = this.Categorys.Where(c => c.CategoryID <= 0).ToList();
            DataProcess<Category> categoryDA = new DataProcess<Category>();
            categoryDA.Insert(dataSourceUpdate.ToArray());
        }

        private void OnDelete()
        {
            var dataSourceUpdate = this.Categorys.Where(c => c.CategoryID <= 0).ToList();
            DataProcess<Category> categoryDA = new DataProcess<Category>();
            categoryDA.Insert(dataSourceUpdate.ToArray());
        }

        private void OnMouseMove()
        {
            frmReceivingDocuments frm = new frmReceivingDocuments();
            frm.ShowDialog();
        }

        private bool CanUpdate()
        {
            return true;
        }

        public void LoadCategory()
        {
            // Init command
            this.insertCommand = new DelegateCommand(OnInsert, CanUpdate);
            this.updateCommand = new DelegateCommand(OnUpdate, CanUpdate);
            this.deleteCommand = new DelegateCommand(OnDelete, CanUpdate);
            this.operationCommand = new DelegateCommand(OnMouseMove, CanUpdate);
            this.loadData();
        }
        private void loadData()
        {
            DataProcess<Category> categoryDA = new DataProcess<Category>();
            var dataSource = new ObservableCollection<Category>(categoryDA.Select());
            this.Categorys = dataSource;
        }
    }
}
