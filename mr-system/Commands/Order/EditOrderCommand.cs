using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using mr_system.Model;

namespace mr_system.Commands
{
    public class EditOrderCommand : ICommand
    {

        private OrderCatalog _orderCatalog;
        private OrderMasterDetailsViewModel _orderMasterDetailsViewModel;

        public EditOrderCommand(OrderCatalog orderCatalog, OrderMasterDetailsViewModel mdvm)
        {
            _orderCatalog = orderCatalog;
            _orderMasterDetailsViewModel = mdvm;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _orderCatalog.Delete(_orderMasterDetailsViewModel.ItemViewModelSelected.Key);
            _orderCatalog.Create(new Orders(_orderMasterDetailsViewModel.ItemViewModelSelected.CaseOwner,
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
            _orderCatalog.Save();
        }

        public event EventHandler CanExecuteChanged;
    }
}
