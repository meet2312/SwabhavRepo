using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExampleApp.Vehicles
{
    class Car : IMovable
    {
        private string _carname;
        private string _cardescription;
        public void Move()
        {
            Console.WriteLine("Car " +this.CarName+ " is moving");
        }

        public Car(string carname, string cardescription)
        {
            this._carname = carname;
            this._cardescription = cardescription;
        }

        public string CarName
        {
            get
            {
                return _carname;
            }
        }
        public string CarDescription
        {
            get
            {
                return _cardescription;
            }
        }
    }
}
