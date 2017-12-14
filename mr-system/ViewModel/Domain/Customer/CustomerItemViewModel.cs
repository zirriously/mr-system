﻿using System;
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

        public int Key => _domainObject.Key;

        public string FirstName
        {
            get { return _domainObject.FirstName; }
            set
            {
                _domainObject.FirstName = value;
                OnPropertyChanged();
            }
        }

        public string LastName
        {
            get { return _domainObject.LastName; }
            set
            {
                _domainObject.LastName = value;
                OnPropertyChanged();
            }
        }

        public string PhoneNumber
        {
            get { return _domainObject.Phone; }
            set
            {
                _domainObject.Phone = value;
                OnPropertyChanged();
            }
        }

        public string Address
        {
            get { return _domainObject.Adress; }
            set
            {
                _domainObject.Adress = value;
                OnPropertyChanged();
            }
        }

        public string City
        {
            get { return _domainObject.City; }
            set
            {
                _domainObject.City = value;
                OnPropertyChanged();
            }
        }

        public string AreaCode
        {
            get { return _domainObject.AreaCode; }
            set
            {
                _domainObject.AreaCode = value;
                OnPropertyChanged();
            }
        }

        public string EmailAddress
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
            get { return _domainObject.Info; }
            set
            {
                _domainObject.Info = value;
                OnPropertyChanged();
            }
        }

        public string CVR
        {
            get { return _domainObject.Cvr; }
            set
            {
                _domainObject.Cvr = value;
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