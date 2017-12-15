using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using mr_system.Model;

namespace mr_system.Commands
{
    public class DeleteCustomerCommand : ICommand
    {
        private CustomerCatalog _catalog;
        private CustomerMasterDetailsViewModel _customerMasterDetailsView;

        public DeleteCustomerCommand(CustomerCatalog catalog, CustomerMasterDetailsViewModel viewModel)
        {
            _catalog = catalog;
            _customerMasterDetailsView = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return _customerMasterDetailsView.ItemViewModelSelected != null;
        }

        public void Execute(object parameter)
        {
            _catalog.Delete(_customerMasterDetailsView.ItemViewModelSelected.DomainObject.Key);

            _customerMasterDetailsView.ItemViewModelSelected = null;

            _customerMasterDetailsView.RefreshCustomerItemViewModelCollection();

            _catalog.Save();
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler CanExecuteChanged;
    }
}
