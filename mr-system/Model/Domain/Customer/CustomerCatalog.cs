using System.Collections.Generic;
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

            Create(new Customer("Albert", "hej", 14, "vej 2"));
            Create(new Customer("Per", "ff", 4, "ff 4"));
            Create(new Customer("Tristan", "smart@gmail.com", 2222, "ff 5"));
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
