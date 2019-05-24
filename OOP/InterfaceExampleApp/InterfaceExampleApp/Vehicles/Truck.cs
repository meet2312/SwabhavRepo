using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExampleApp.Vehicles
{
    class Truck : IMovable
    {
        private string _truckname;
        private string _truckdescription;
        public void Move()
        {
            Console.WriteLine("Truck " + this.TruckName + " is moving");
        }

        public Truck(string truckname, string truckdescription)
        {
            this._truckname = truckname;
            this._truckdescription = truckdescription;
        }

        public string TruckName
        {
            get
            {
                return _truckname;
            }
        }
        public string TruckDescription
        {
            get
            {
                return _truckdescription;
            }
        }
    }
}
