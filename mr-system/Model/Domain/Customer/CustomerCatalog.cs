using System;
using System.Collections.Generic;
using System.Linq;
using Windows.Foundation.Metadata;
using Windows.Media.SpeechRecognition;
using mr_system.FilePersistence;

namespace mr_system.Model
{
    public class CustomerCatalog
    {
        private static int _keyCount = 1;
        private Dictionary<int, Customer> _customers;
        private FileSource<Customer> _fileSource;
        private List<Customer> _customerList;
        private List<int> _maxKeyInList;


        public CustomerCatalog()
        {
            _fileSource = new FileSource<Customer>(new FileStringPersistence(), new JSONConverter<Customer>());
            _customerList = new List<Customer>();
            _customers = new Dictionary<int, Customer>();
            _maxKeyInList = new List<int>();
            //Create(new Customer("36452658", "Albert", "Sørensen", "Mail@mail.dk", "66254292", "Søndergade 20", "4180"));
            //Create(new Customer("36452658", "Frank", "Sørensen", "Mail@mail.dk", "66254292", "Søndergade 20", "4180"));
            //Create(new Customer("36452658", "Mikkel", "Sørensen", "Mail@mail.dk", "66254292", "Søndergade 20", "4180"));
            //Create(new Customer("36452658", "Per", "Sørensen", "Mail@mail.dk", "66254292", "Søndergade 20", "4180"));
            //Create(new Customer("36452658", "Bob", "Sørensen", "Mail@mail.dk", "66254292", "Søndergade 20", "4180"));
            //Create(new Customer("36452658", "Troels", "Sørensen", "Mail@mail.dk", "66254292", "Søndergade 20", "4180"));
            //Create(new Customer("36452658", "Peter", "Sørensen", "Mail@mail.dk", "66254292", "Søndergade 20", "4180"));
        }

        public List<Customer> Customers
        {
            get { return _customers.Values.ToList(); }
        }

        public void Create(Customer s)
        {
            s.Key = _keyCount++;
            _customers.Add(s.Key, s);
        }

        public void Delete(int key)
        {
            _customers.Remove(key);
        }

        public async void Load()
        {
            _customerList = await _fileSource.Load();

            foreach (var customer in _customerList)
            {
                _customers.Add(customer.Key, customer);
                _maxKeyInList.Add(customer.Key);
            }

            _keyCount = _maxKeyInList.Max() +1;
        }

        public async void Save()
        {
            await _fileSource.Save(Customers);
        }
    }
}
