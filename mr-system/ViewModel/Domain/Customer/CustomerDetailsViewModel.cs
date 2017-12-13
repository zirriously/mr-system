using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace mr_system
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

        public double Cvr
        {
            get { return _domainObject.Cvr; }
            set
            {
                _domainObject.Cvr = value;
                OnPropertyChanged();
            }
        }

        public string Navn
        {
            get { return _domainObject.Navn; }
            set
            {
                _domainObject.Navn = value;
                OnPropertyChanged();
            }
        }

        //public string Att
        //{
        //    get { return _domainObject.Att; }
        //    set
        //    {
        //        _domainObject.Att = value;
        //        OnPropertyChanged();
        //    }
        //}

        public string Adr
        {
            get { return _domainObject.Adresse; }
            set
            {
                _domainObject.Adresse = value;
                OnPropertyChanged();
            }
        }

        public double postnr
        {
            get { return _domainObject.PostNummer; }
            set
            {
                _domainObject.PostNummer = value;
                OnPropertyChanged();
            }
        }

        public double Tlf
        {
            get { return _domainObject.TelefonNummer; }
            set
            {
                _domainObject.TelefonNummer = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get { return _domainObject.EmailAddresse; }
            set
            {
                _domainObject.EmailAddresse = value;
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

        public string ForLev
        {
            get { return _domainObject.ForventetLevering; }
            set
            {
                _domainObject.ForventetLevering = value;
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