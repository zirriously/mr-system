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
        }

        public string OrderInfo
        {
            get { return _domainObject.OrderInfo; }
        }

        public string CaseOwner
        {
            get { return _domainObject.CaseOwner; }
        }

        public string ExpectedDelivery
        {
            get { return _domainObject.ExpectedDelivery; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}