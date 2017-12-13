using System.ComponentModel;
using System.Runtime.CompilerServices;
using mr_system.Model;

namespace mr_system
{
    public class OrderDetailsViewModel : INotifyPropertyChanged
    {
        private Orders _domainObject;

        public OrderDetailsViewModel(Orders domainObject)
        {
            _domainObject = domainObject;
        }



        public Orders DomainObject
        {
            get { return _domainObject; }
        }

        //public string OrderInfo

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}