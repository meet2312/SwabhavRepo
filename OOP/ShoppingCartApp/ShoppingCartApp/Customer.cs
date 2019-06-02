using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    class Customer
    {
        private string _customername;
        private List<Order> _orders = new List<Order>();
        private Order _order;
        private List<LineItemCart> finalcart;
      //  protected LineItemCart itemcartss;

        public Customer(string customername, Order order)
        {
            this._customername = customername;
            this._order = order;
        }

        public string Customername
        {
            get
            {
                return _customername;
            }

        }

        public Order Order
        {
            get
            {
                return _order;
            }

        }

     //   public LineItemCart Itemcartss
    //    {
   //         get
   //         {
   //             return itemcartss;
   //         }

   //     }

        public List<LineItemCart> Finalcart
        {
            get
            {
                return finalcart=Order.Cartitems;
            }

        }

        public void AddOrder(Order orders)
        {
            _orders.Add(orders);
        }

        public void OrderDetails()
        {
            foreach (var c in _orders)
            {
                Console.WriteLine("Order date is " + c.Orderdate + " CheckoutCost :" + c.CheckoutCost() + " order summary:");

            }
           // return "Order date is " + _order.Orderdate + " Order summary:" + _order.CheckoutCost() + "";

        }

      
    }
}
