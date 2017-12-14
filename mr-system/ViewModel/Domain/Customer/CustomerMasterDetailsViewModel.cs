using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using mr_system.Commands;
using mr_system.Model;

namespace mr_system
{
    public class CustomerMasterDetailsViewModel : INotifyPropertyChanged
    {
        private CustomerCatalog _catalog;
        //private CustomerDetailsViewModel _customerDetailsViewModel;
        private CustomerItemViewModel _customerItemViewModel;

        private DeleteCommand _deleteCommand;
        private NewCommand _newCommand;

        public CustomerMasterDetailsViewModel()
        {
            _catalog = new CustomerCatalog();
            _customerItemViewModel = null;
            //_customerDetailsViewModel = null;
            _deleteCommand = new DeleteCommand(_catalog, this);
            _newCommand = new NewCommand(_catalog, this);
        }

       
        
            private List<CustomerItemViewModel> CreateItemViewModelCollection(CustomerCatalog catalog)
            {
                List<CustomerItemViewModel> items = new List<CustomerItemViewModel>();
                foreach (var obj in catalog.Customers)
                {
                    items.Add(new CustomerItemViewModel(obj));
                }
                return items;
            }
        


        public List<CustomerItemViewModel> ItemViewModelCollection
        {
            get { return CreateItemViewModelCollection(_catalog); }
        }

        public CustomerItemViewModel CustomerItem
        {
            get { return _customerItemViewModel; }
            private set
            {
                _customerItemViewModel = value;
                OnPropertyChanged();
            }
        }

        public ICommand DeleteCommand
        {
            get { return _deleteCommand; }
        }

        public ICommand NewCommand
        {
            get { return _newCommand; }
        }

        public CustomerItemViewModel ItemViewModelSelected
        {
            get { return _customerItemViewModel; }
            set
            {
                _customerItemViewModel = value;
                OnPropertyChanged();
                _deleteCommand.RaiseCanExecuteChanged();
            }
        }

        public void RefreshCustomerItemViewModelCollection()
        {
            OnPropertyChanged(nameof(ItemViewModelCollection));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}