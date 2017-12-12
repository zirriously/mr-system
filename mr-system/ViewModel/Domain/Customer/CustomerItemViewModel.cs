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

        public double TelefonNummer
        {
            get { return _domainObject.TelefonNummer; }
        }

        public string Mail
        {
            get { return _domainObject.EmailAddresse; }
        }

        public string Addresse
        {
            get { return _domainObject.Adresse; }
        }

        

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}