using System;
using System.Windows.Input;
using mr_system.Model;

namespace mr_system.Commands.Order
{
    public class DeleteOrderCommand : ICommand
    {

        private OrderCatalog _catalog;
        private OrderMasterDetailsViewModel _orderMasterDetailsViewModel;

        public DeleteOrderCommand(OrderCatalog catalog, OrderMasterDetailsViewModel viewModel)
        {
            _catalog = catalog;
            _orderMasterDetailsViewModel = viewModel;
        }
        public bool CanExecute(object parameter)
        {
            return _orderMasterDetailsViewModel.ItemViewModelSelected != null;
        }

        public void Execute(object parameter)
        {
            _catalog.Delete(_orderMasterDetailsViewModel.ItemViewModelSelected.DomainObject.Key);

            _orderMasterDetailsViewModel.ItemViewModelSelected = null;

            _orderMasterDetailsViewModel.RefreshOrderItemViewModelCollection();
            _catalog.Save();
        }
        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
        public event EventHandler CanExecuteChanged;
    }
}