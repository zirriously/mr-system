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

        public string CaseOwner
        {
            get { return _domainObject.CaseOwner; }
            set
            {
                _domainObject.CaseOwner = value;
                OnPropertyChanged();
            }
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
            get { return _domainObject.Measurements1; }
            set
            {
                _domainObject.Measurements1 = value;
                OnPropertyChanged();
            }
        } 

        

        public string NumberOfItems
        {
            get { return _domainObject.NumberOfItems; }
            set
            {
                _domainObject.NumberOfItems = value;
                OnPropertyChanged();
            } 
        }

        public string Price
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
            get { return _domainObject.Delivery; }
            set
            {
                _domainObject.Delivery = value;
                OnPropertyChanged();
            }
        }

        public int Key
        {
            get { return _domainObject.Key; }
            set
            {
                _domainObject.Key = value;
                OnPropertyChanged();
            }
        }

        public string Media1
        {
            get { return _domainObject.Media1; }
            set
            {
                _domainObject.Media1 = value;
                OnPropertyChanged();
            }
        }

        public string Media2
        {
            get { return _domainObject.Media2; }
            set
            {
                _domainObject.Media2 = value;
                OnPropertyChanged();
            }
        }

        public string Laminat1
        {
            get { return _domainObject.Laminat1; }
            set
            {
                _domainObject.Laminat1 = value;
                OnPropertyChanged();
            }
        }

        public string Laminat2
        {
            get { return _domainObject.Laminat2; }
            set
            {
                _domainObject.Laminat2 = value;
                OnPropertyChanged();
            }
        }

        public string Measurements2
        {
            get { return _domainObject.Measurements2; }
            set
            {
                _domainObject.Measurements2 = value;
                OnPropertyChanged();
            }
        }

        public string DtpPrice
        {
            get { return _domainObject.DtpPrice; }
            set
            {
                _domainObject.DtpPrice = value;
                OnPropertyChanged();
            }
        }

        public string SpecialOrderInfo
        {
            get { return _domainObject.SpecialOrderInfo; }
            set
            {
                _domainObject.SpecialOrderInfo = value; 
                OnPropertyChanged();
            }
        }

        //public string ExpectedDelivery
        //{
        //    get { return _domainObject.; }
        //    set
        //    {
        //        _domainObject.ExpectedDelivery = value;
        //        OnPropertyChanged();
        //    }
        //}

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}