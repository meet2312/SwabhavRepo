using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
   public class RestaurantFacade
    {
        private IPizza _pizzaprovider;
        private IBread _breadprovider;
        public RestaurantFacade()
        {
            _pizzaprovider = new PizzaProvider();
            _breadprovider = new BreadProvider();
        }
        public void GetNonVegPizza()
        {
            _pizzaprovider.GetNonVegPizza();
        }
        public void GetVegPizza()
        {
            _pizzaprovider.GetVegPizza();
        }
        public void GetGarlicBread()
        {
            _breadprovider.GetGarlicBread();
        }
        public void GetCheesyGarlicBread()
        {
            _breadprovider.GetCheesyGarlicBread();
        }
    }
}
