using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using mr_system.Model;

namespace mr_system
{
    public class OrderMasterDetailsViewModel : INotifyPropertyChanged
    {
        private OrderCatalog _catalog;
        private OrderItemViewModel _orderItemViewModelSelected;

        public OrderMasterDetailsViewModel()
        {
            _catalog = new OrderCatalog();
            _orderItemViewModelSelected = null;
        }

        private List<OrderItemViewModel> CreateItemViewModelCollection(OrderCatalog catalog)
        {
            List<OrderItemViewModel> items = new List<OrderItemViewModel>();
            foreach (var obj in catalog.Orders)
            {
                items.Add(new OrderItemViewModel(obj));
            }
            return items;
        }


        public List<OrderItemViewModel> OrderItemViewModelCollection
        {
            get { return CreateItemViewModelCollection(_catalog); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}