using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExampleApp.Vehicles
{
    class Bike : IMovable
    {
        private string _bikename;
        private string _bikedescription;
        public void Move()
        {

            Console.WriteLine("Bike " + this.BikeName + " is moving");
        }
        public Bike(string bikename, string bikedescription)
        {
            this._bikename = bikename;
            this._bikedescription = bikedescription;
        }
        public string BikeName
        {
            get
            {
                return _bikename;
            }
        }
        public string BikeDescription
        {
            get
            {
                return _bikedescription;
            }
        }

        
    }
}
