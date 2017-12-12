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
