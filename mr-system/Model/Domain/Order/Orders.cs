using Windows.Security.Cryptography.Certificates;

namespace mr_system.Model
{
    public class Orders
    {
        private int _key;
        public Orders (string ordreinfo, double pris, string materials, string production, string measurements,
            int numberOfItems, string delivery)
        {
            Key = -1;
            OrderInfo = ordreinfo;
            Price = pris;
            Materials = materials;
            Production = production;
            Measurements = measurements;
            NumberOfItems = numberOfItems;
            DeliveryInfo = delivery;
        }


        public int Key
        {
            get { return _key; }
            set { _key = value; }
        }
        public string OrderInfo { get; set; }

        public string Measurements { get; set; }

        public int NumberOfItems { get; set; }

        public double Price { get; set; }

        public string Materials { get; set; }

        public string Production { get; set; }

        public string DeliveryInfo { get; set; }
    }
}