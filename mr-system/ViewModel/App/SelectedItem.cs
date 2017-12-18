using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mr_system.ViewModel.App
{
    public class Singleton
    {
        private static Singleton singletonInstance = CreateSingleton();

        private Singleton()
        {
        }

        private static Singleton CreateSingleton()
        {
            if (singletonInstance == null)
            {
                singletonInstance = new Singleton();
            }

            return singletonInstance;
        }

        public static Singleton Instance
        {
            get { return singletonInstance; }
        }

        public int Key { get; set; }

        public string Cvr { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string AreaCode { get; set; }

        public string Info { get; set; }

        public bool Selected { get; set; }

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

        public bool OrderSelected { get; set; }

    }
}
