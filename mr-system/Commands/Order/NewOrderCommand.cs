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

            
            _catalog.Create(new Orders(_orderMasterDetailsViewModel.ItemViewModelSelected.CaseOwner,
                _orderMasterDetailsViewModel.ItemViewModelSelected.OrderName,
                _orderMasterDetailsViewModel.ItemViewModelSelected.OrderInfo,
                _orderMasterDetailsViewModel.ItemViewModelSelected.Price,
                _orderMasterDetailsViewModel.ItemViewModelSelected.Materials,
                _orderMasterDetailsViewModel.ItemViewModelSelected.Production,
                _orderMasterDetailsViewModel.ItemViewModelSelected.Measurements,
                _orderMasterDetailsViewModel.ItemViewModelSelected.NumberOfItems,
                _orderMasterDetailsViewModel.ItemViewModelSelected.DeliveryInfo,
                _orderMasterDetailsViewModel.ItemViewModelSelected.Media1,
                _orderMasterDetailsViewModel.ItemViewModelSelected.Media2,
                _orderMasterDetailsViewModel.ItemViewModelSelected.Laminat1,
                _orderMasterDetailsViewModel.ItemViewModelSelected.Laminat2,
                _orderMasterDetailsViewModel.ItemViewModelSelected.Measurements2,
                _orderMasterDetailsViewModel.ItemViewModelSelected.DtpPrice,
                _orderMasterDetailsViewModel.ItemViewModelSelected.SpecialOrderInfo));
            _orderMasterDetailsViewModel.RefreshOrderItemViewModelCollection();
            _catalog.Save();
        }

        public event EventHandler CanExecuteChanged;
    }
}