namespace mr_system.Model
{
    public class Orders
    {
        private string _orderInfo;
        private string _measurements;
        private string _numberOfItems;
        private string _price;
        private string _materials;
        private string _production;
        private string _deliveryInfo;

        public string OrderInfo
        { get { return _orderInfo; }
          set {_orderInfo = value;} 
        }
        public string Measurements
        {
            get { return _measurements; }
            set {_measurements = value; }
        }
        public string NumberOfItems
        {
            get { return _numberOfItems; }
            set {_numberOfItems = value; }
        }
        public string Price
        {
            get { return _price; }
            set {_price= value; }
        }
        public string Materials
        {
            get { return _materials; }
            set {_materials = value; }
        }
        public string Production
        {
            get { return _production; }
            set {_production = value; }
        }
        public string DeliveryInfo
        {
            get { return _deliveryInfo; }
            set {_deliveryInfo = value; }
        }
    }
}