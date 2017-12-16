using System;
using System.Windows.Input;
using mr_system.Model;

namespace mr_system.Commands
{
    public class RefreshCustomerCommand : ICommand
    {
        private CustomerMasterDetailsViewModel _mdvm;
        private CustomerCatalog _catalog;

        public RefreshCustomerCommand(CustomerMasterDetailsViewModel mdvm, CustomerCatalog catalog)
        {
            _mdvm = mdvm;
            _catalog = catalog;
        }

        
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _mdvm.RefreshCustomerItemViewModelCollection();
        }

        public event EventHandler CanExecuteChanged;
    }
}