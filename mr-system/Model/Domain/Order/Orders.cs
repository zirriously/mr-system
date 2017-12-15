using Windows.Security.Cryptography.Certificates;

namespace mr_system.Model
{
    public class Orders
    {
        public Orders(string orderName = "", string orderInfo = "", string pris = "", string materials = "", string production = "",
            string measurements = "",
            string numberOfItems = "", string delivery = "")
        {
            Key = -1;
            OrderInfo = orderInfo;
            Price = pris;
            Materials = materials;
            Production = production;
            Measurements = measurements;
            NumberOfItems = numberOfItems;
            DeliveryInfo = delivery;
            OrderName = orderName;
        }

        public string ExpectedDelivery { get; set; }


        public string OrderName { get; set; }

        public int Key { get; set; }

        public string OrderInfo { get; set; }

        public string Measurements { get; set; }

        public string NumberOfItems { get; set; }

        public string Price { get; set; }

        public string Materials { get; set; }

        public string Production { get; set; }

        public string DeliveryInfo { get; set; }
    }
}