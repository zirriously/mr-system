﻿using System.Collections.Generic;
using System.Linq;

namespace mr_system.Model
{
    public class OrderCatalog
    {
        private static int _keyCount = 1;
        private Dictionary<int, Orders> _orders;

      
        public OrderCatalog()
        {
            _orders = new Dictionary<int, Orders>();

          
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
      
    }
}