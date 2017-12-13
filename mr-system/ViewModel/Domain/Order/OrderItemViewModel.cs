using System.ComponentModel;
using System.Runtime.CompilerServices;
using mr_system.Model;

namespace mr_system
{
    public class OrderItemViewModel : INotifyPropertyChanged
    {
        private Orders _domainObject;

        public OrderItemViewModel(Orders domainObject)
        {
            _domainObject = domainObject;
        }

        public Orders DomainObject
        {
            get { return _domainObject; }
        }

        public string OrderName
        {
           get { return _domainObject.OrderName; }
            set
            {
                _domainObject.OrderName = value;
                OnPropertyChanged();
            }
        }

        public string OrderInfo
        {
            get { return _domainObject.OrderInfo; }
            set
            {
                _domainObject.OrderInfo = value;
                OnPropertyChanged();
            }
        }


        public string Measurements
        {
            get { return _domainObject.Measurements; }
            set
            {
                _domainObject.Measurements = value;
                OnPropertyChanged();
            }
        } 

        

        public int NumberOfItems
        { get { return _domainObject.NumberOfItems; }
            set
            {
                _domainObject.NumberOfItems = value;
                OnPropertyChanged();
            } 
        }

        public double Price
        {
            get { return _domainObject.Price; }
            set
            {
                _domainObject.Price = value;
                OnPropertyChanged();
            }
        }

        public string Materials
        {
            get { return _domainObject.Materials; }
            set
            {
                _domainObject.Materials = value;
                OnPropertyChanged();
            }
        }

        public string Production
        {
            get { return _domainObject.Production; }
            set
            {
                _domainObject.Production = value;
                OnPropertyChanged();
            }
        }

        public string DeliveryInfo
        {
            get { return _domainObject.DeliveryInfo; }
            set
            {
                _domainObject.DeliveryInfo = value;
                OnPropertyChanged();
            }
        }

        public string ExpectedDelivery
        {
            get { return _domainObject.ExpectedDelivery; }
            set
            {
                _domainObject.ExpectedDelivery = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}