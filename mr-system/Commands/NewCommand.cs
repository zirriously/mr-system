using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using mr_system.Model;

namespace mr_system.Commands
{
    public class NewCommand : ICommand
    {

        private CustomerCatalog _catalog;
        private CustomerMasterDetailsViewModel _customerMasterDetailsViewModel;

        public NewCommand(CustomerCatalog catalog, CustomerMasterDetailsViewModel mdvm)
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
            _catalog.Create(new Customer());
            _customerMasterDetailsViewModel.RefreshCustomerItemViewModelCollection();
        }

        public event EventHandler CanExecuteChanged;
    }
}
