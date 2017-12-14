using System;
using System.Windows.Input;
using mr_system.Model;

namespace mr_system.Commands.Order
{
    public class NewOrderCommand : ICommand
    {
        private OrderCatalog _catalog;
        private OrderMasterDetailsViewModel _orderMasterDetailsViewModel;

        public NewOrderCommand(OrderCatalog catalog, OrderMasterDetailsViewModel mdvm)
        {
            _catalog = catalog;
            _orderMasterDetailsViewModel = mdvm;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _catalog.Create(new Orders());
            _orderMasterDetailsViewModel.RefreshOrderItemViewModelCollection();
        }

        public event EventHandler CanExecuteChanged;
    }
}