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
    }
}
