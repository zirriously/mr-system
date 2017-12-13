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

        public string FirstName
        {
            get { return _domainObject.FirstName; }
        }

        public string LastName
        {
            get { return _domainObject.LastName; }
        }

        public double TelefonNummer
        {
            get { return _domainObject.Phone; }
        }

        public string Mail
        {
            get { return _domainObject.Email; }
        }

        public string Addresse
        {
            get { return _domainObject.Adress; }
        }

        

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}