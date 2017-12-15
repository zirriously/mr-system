using Windows.Security.Cryptography.Certificates;

namespace mr_system.Model
{
    public class Orders
    {
        public Orders(string caseOwner = "", string orderName = "", string orderInfo = "", string price = ""
            , string materials = "", string production = "", string measurements1 = "", string numberOfItems = "",
            string delivery = "", string media1 = "", string media2 = "", string laminat1 = "",
            string laminat2 = "", string measurements2 = "", string dtpPrice = "", string specialOrderInfo = "")
        {
            Key = -1;
            CaseOwner = caseOwner;
            OrderName = orderName;
            OrderInfo = orderInfo;
            Price = price;
            Materials = materials;
            Production = production;
            Measurements1 = measurements1;
            NumberOfItems = numberOfItems;
            Delivery = delivery;
            Media1 = media1;
            Media2 = media2;
            Laminat1 = laminat1;
            Laminat2 = laminat2;
            Measurements2 = measurements2;
            DtpPrice = dtpPrice;
            SpecialOrderInfo = specialOrderInfo;
        }

        public string CaseOwner { get; set; }
        public string OrderName { get; set; }
        public string OrderInfo { get; set; }
        public string Price { get; set; }
        public string Materials { get; set; }
        public string Production { get; set; }
        public string Measurements1 { get; set; }
        public string Measurements2 { get; set; }
        public string NumberOfItems { get; set; }
        public string Delivery { get; set; }
        public string Media1 { get; set; }
        public string Media2 { get; set; }
        public string Laminat1 { get; set; }
        public string Laminat2 { get; set; }
        public string DtpPrice { get; set; }
        public string SpecialOrderInfo { get; set; }

        public int Key { get; set; }
    }
}