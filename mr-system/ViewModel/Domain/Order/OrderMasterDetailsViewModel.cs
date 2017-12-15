using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using mr_system.Commands.Order;
using mr_system.Model;

namespace mr_system
{
    public class OrderMasterDetailsViewModel : INotifyPropertyChanged
    {
        private OrderCatalog _catalog;
        private OrderItemViewModel _orderItemViewModelSelected;
        private DeleteOrderCommand _deleteCommand;
        private NewOrderCommand _newOrderCommand;
        private SaveOrderCommand _saveCommand;

        public OrderMasterDetailsViewModel()
        {
            _catalog = new OrderCatalog();
            _orderItemViewModelSelected = null;
            _deleteCommand = new DeleteOrderCommand(_catalog, this);
            _newOrderCommand = new NewOrderCommand(_catalog, this);
            _saveCommand = new SaveOrderCommand(_catalog);
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
        public OrderItemViewModel ItemViewModelSelected
        {
            get { return _orderItemViewModelSelected; }
            set
            {
                _orderItemViewModelSelected = value;
                OnPropertyChanged();
                _deleteCommand.RaiseCanExecuteChanged();
                
            }
        }

        public ICommand DeleteCommand
        {
            get {return _deleteCommand;}
        }

        public ICommand NewCommand
        {
            get { return _newOrderCommand; }
        }

        public ICommand SaveCommand
        {
            get { return _saveCommand; }
        }
        public void RefreshOrderItemViewModelCollection()
        {
            OnPropertyChanged(nameof(OrderItemViewModelCollection));
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