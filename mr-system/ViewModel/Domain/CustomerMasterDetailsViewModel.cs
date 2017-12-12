using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using mr_system.Model;

namespace mr_system
{
    public class CustomerMasterDetailsViewModel : INotifyPropertyChanged
    {
        private CustomerCatalog _catalog;
        private CustomerDetailsViewModel _customerDetailsViewModel;
        private CustomerItemViewModel _customerItemViewModel;

        public CustomerMasterDetailsViewModel()
        {
            _catalog = new CustomerCatalog();
            _customerItemViewModel = null;
            _customerDetailsViewModel = null;
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

        public CustomerDetailsViewModel CustomerDetails
        {
            get { return _customerDetailsViewModel; }
            private set
            {
                _customerDetailsViewModel = value;
                OnPropertyChanged();
            }
        }

        public CustomerItemViewModel ItemViewModelSelected
        {
            get { return _customerItemViewModel; }
            set {
                _customerItemViewModel = value;

                if (_customerItemViewModel == null)
                {
                    CustomerDetails = null;
                }
                else
                {
                    CustomerDetails = new CustomerDetailsViewModel(
                        _customerItemViewModel.DomainObject);
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}