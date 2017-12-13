﻿using Windows.Security.Cryptography.Certificates;

namespace mr_system.Model
{
    public class Orders
    {
        public Orders (string orderInfo, double pris, string materials, string production, string measurements,
            int numberOfItems, string delivery)
        {
            Key = -1;
            OrderInfo = orderInfo;
            Price = pris;
            Materials = materials;
            Production = production;
            Measurements = measurements;
            NumberOfItems = numberOfItems;
            DeliveryInfo = delivery;
            
        }

        public string ExpectedDelivery { get; set; }
        public string CaseOwner { get; set; }

        public string OrderName { get; set; }

        public int Key { get; set; }

        public string OrderInfo { get; set; }

        public string Measurements { get; set; }

        public int NumberOfItems { get; set; }

        public double Price { get; set; }

        public string Materials { get; set; }

        public string Production { get; set; }

        public string DeliveryInfo { get; set; }
    }
}