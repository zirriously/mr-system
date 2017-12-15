using System.Collections.Generic;
using System.Linq;
using mr_system.FilePersistence;

namespace mr_system.Model
{
    public class OrderCatalog
    {
        private static int _keyCount = 1;
        private Dictionary<int, Orders> _orders;
        private FileSource<Orders> _fileSource;

      
        public OrderCatalog()
        {
            _fileSource = new FileSource<Orders>(new FileStringPersistence(), new JSONConverter<Orders>());
            _orders = new Dictionary<int, Orders>();
            Create(new Orders("Pølse", "5000"));
          
        }

        public List<Orders> Orders
        {
            get { return _orders.Values.ToList(); }
        }
      
        public void Create(Orders s)
        {
            s.Key = _keyCount++;
            _orders.Add(s.Key, s);
        }

        public void Delete(int key)
        {
            _orders.Remove(key);
        }
        public async void Save()
        {
            await _fileSource.Save(Orders);
        }
    }
}