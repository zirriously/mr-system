using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using mr_system.Model;

namespace mr_system
{
    public class CustomerMasterDetailsViewModel : INotifyPropertyChanged
    {
        private CustomerCatalog _catalog;
        private CustomerItemViewModel _customerItemViewModel;

        public CustomerMasterDetailsViewModel()
        {
            _catalog = new CustomerCatalog();
            _customerItemViewModel = null;
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

        public CustomerItemViewModel ItemViewModelSelected
        {
            get { return _customerItemViewModel; }
            set
            {
                _customerItemViewModel = value;
                OnPropertyChanged();
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