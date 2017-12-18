using System;
using System.Windows.Input;
using mr_system.Model;

namespace mr_system.Commands.Order
{
    public class RefreshOrderCommand : ICommand
    {
        private OrderMasterDetailsViewModel _orderMasterDetailsViewModel;
        private OrderCatalog _catalog;

        public RefreshOrderCommand(OrderMasterDetailsViewModel mdvm, OrderCatalog catalog)
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
            _orderMasterDetailsViewModel.RefreshOrderItemViewModelCollection();
        }

        public event EventHandler CanExecuteChanged;
    }
}