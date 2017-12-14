﻿using System.Collections.Generic;
using System.Linq;
using Windows.Foundation.Metadata;

namespace mr_system.Model
{
    public class CustomerCatalog
    {


        private static int _keyCount = 1;
        private Dictionary<int, Customer> _customers;


        public CustomerCatalog()
        {
            _customers = new Dictionary<int, Customer>();
            Create(new Customer("36452658", "Albert", "Sørensen", "Mail@mail.dk", "66254292", "Søndergade 20", "4180"));
            Create(new Customer("36452658", "Frank", "Sørensen", "Mail@mail.dk", "66254292", "Søndergade 20", "4180"));
            Create(new Customer("36452658", "Mikkel", "Sørensen", "Mail@mail.dk", "66254292", "Søndergade 20", "4180"));
            Create(new Customer("36452658", "Per", "Sørensen", "Mail@mail.dk", "66254292", "Søndergade 20", "4180"));
            Create(new Customer("36452658", "Bob", "Sørensen", "Mail@mail.dk", "66254292", "Søndergade 20", "4180"));
            Create(new Customer("36452658", "Troels", "Sørensen", "Mail@mail.dk", "66254292", "Søndergade 20", "4180"));
            Create(new Customer("36452658", "Peter", "Sørensen", "Mail@mail.dk", "66254292", "Søndergade 20", "4180"));
            Create(new Customer());
            Create(new Customer("400", lastName: "hej", email: "44@mm.com"));

            for (int i = 0; i < 10; i++)
            {
                Create(new Customer("4", "hej", "2"));
            }
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
    }
}
