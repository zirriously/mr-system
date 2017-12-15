using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using mr_system.Model;

namespace mr_system.Commands
{
    public class NewCustomerCommand : ICommand
    {
 
        private CustomerCatalog _catalog;
        private CustomerMasterDetailsViewModel _customerMasterDetailsViewModel;

        public NewCustomerCommand(CustomerCatalog catalog, CustomerMasterDetailsViewModel mdvm)
        {
            _catalog = catalog;
            _customerMasterDetailsViewModel = mdvm;
        }
        public bool CanExecute(object parameter)

        {
            return true;
        }

        public void Execute(object parameter)
        {
            _catalog.Create(new Customer(_customerMasterDetailsViewModel.ItemViewModelSelected.CVR, 
                _customerMasterDetailsViewModel.ItemViewModelSelected.FirstName, 
                _customerMasterDetailsViewModel.ItemViewModelSelected.LastName, 
                _customerMasterDetailsViewModel.ItemViewModelSelected.EmailAddress, 
                _customerMasterDetailsViewModel.ItemViewModelSelected.PhoneNumber, 
                _customerMasterDetailsViewModel.ItemViewModelSelected.Address, 
                _customerMasterDetailsViewModel.ItemViewModelSelected.City, 
                _customerMasterDetailsViewModel.ItemViewModelSelected.AreaCode, 
                _customerMasterDetailsViewModel.ItemViewModelSelected.Info));
            _customerMasterDetailsViewModel.RefreshCustomerItemViewModelCollection();
            _catalog.Save();
        }

        public event EventHandler CanExecuteChanged;
    }
}
