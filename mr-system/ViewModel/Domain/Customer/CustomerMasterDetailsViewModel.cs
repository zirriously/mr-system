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
        private CustomerItemViewModel _customerItemViewModel;

        private DeleteCustomerCommand _deleteCommand;
        private NewCustomerCommand _newCommand;
        private SaveCustomerCommand _saveCommand;
        private RefreshCustomerCommand _refreshCommand;

        public CustomerMasterDetailsViewModel()
        {
            _catalog = new CustomerCatalog();
            _customerItemViewModel = new CustomerItemViewModel(new Customer());
            _deleteCommand = new DeleteCustomerCommand(_catalog, this);
            _newCommand = new NewCustomerCommand(_catalog, this);
            _saveCommand = new SaveCustomerCommand(_catalog);
            _refreshCommand = new RefreshCustomerCommand(this, _catalog);
            RefreshCustomerItemViewModelCollection();
            _catalog.Load();
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

        public ICommand SaveCommand
        {
            get { return _saveCommand; }
        }

        public ICommand RefreshCommand
        {
            get { return _refreshCommand; }
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