using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace mr_system // ikke bruge
{
    public class CustomerDetailsViewModel : INotifyPropertyChanged
    {
        private Customer _domainObject;

        public CustomerDetailsViewModel(Customer domainObject)
        {
            _domainObject = domainObject;
        }

        public Customer DomainObject
        {
            get {return _domainObject;}
        }

        public Int64 Cvr
        {
            get { return _domainObject.Cvr; }
            set
            {
                _domainObject.Cvr = value;
                OnPropertyChanged();
            }
        }

        public string FirstName
        {
            get { return _domainObject.FirstName; }
            set
            {
                _domainObject.FirstName = value;
                OnPropertyChanged();
            }
        }

        

        public string Adr
        {
            get { return _domainObject.Adress; }
            set
            {
                _domainObject.Adress = value;
                OnPropertyChanged();
            }
        }

        public double postnr
        {
            get { return _domainObject.AreaCode; }
            set
            {
                _domainObject.AreaCode = value;
                OnPropertyChanged();
            }
        }

        public Int64 Tlf
        {
            get { return _domainObject.Phone; }
            set
            {
                _domainObject.Phone = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get { return _domainObject.Email; }
            set
            {
                _domainObject.Email = value;
                OnPropertyChanged();
            }
        }
        public string Info
        {
            get { return _domainObject.Information; }
            set
            {
                _domainObject.Information = value;
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