using System.Collections.Generic;
using System.Linq;
using mr_system.FilePersistence;

namespace mr_system.Model
{
    public class OrderCatalog
    {
        private List<Orders> _orderList;
        private Dictionary<int, Orders> _orders;
        private FileSource<Orders> _fileSource;

      
        public OrderCatalog()
        {
            _fileSource = new FileSource<Orders>(new FileStringPersistence(), new JSONConverter<Orders>());
            _orders = new Dictionary<int, Orders>();
            //Create(new Orders("Fox", "Pølse", "5000"));
            _orderList = new List<Orders>();
          
        }

        public List<Orders> Orders
        {
            get { return _orders.Values.ToList(); }
        }
      
        public void Create(Orders s)
        {
            s.Key = _orders.Count == 0 ? 1 : _orders.Keys.Max() + 1;
            _orders.Add(s.Key, s);
        }

        public async void Load()
        {
            _orderList = await _fileSource.Load();


            foreach (var orders in _orderList)
            {
                _orders.Add(orders.Key, orders);
            }
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