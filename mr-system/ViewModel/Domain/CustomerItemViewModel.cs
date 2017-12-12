using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using mr_system.Model;

namespace mr_system
{
    public class CustomerItemViewModel : INotifyPropertyChanged
    {
        private Customer _domainObject;

        public CustomerItemViewModel(Customer domainObject)
        {
            _domainObject = domainObject;
        }

        public Customer DomainObject
        {
            get { return _domainObject; }
        }

        public string Description
        {
            get { return _domainObject.Navn; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}