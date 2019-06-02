using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    class Order
    {
        private int _orderid;
        private DateTime _orderdate;
        private List<LineItemCart> _cartitems = new List<LineItemCart>();
        private LineItemCart cartitem;

        public int Orderid
        {
            get
            {
                return _orderid;
            }

        }

        public DateTime Orderdate
        {
            get
            {
                return _orderdate;
            }
        }

        public LineItemCart Cartitem
        {
            get
            {
                return cartitem;
            }
        }

        public List<LineItemCart> Cartitems
        {
            get
            {
                return _cartitems;
            }

        }

        public void AddItem(LineItemCart cart)
        {
           _cartitems.Add(cart);
           
        }
        

        public Order(int orderid,DateTime orderdate)
        {
            this._orderid = orderid;
            this._orderdate = orderdate;

        }

        public double CheckoutCost()
       {
            double checkout = 0;
            foreach (var e in  _cartitems)
            {
                checkout = checkout+e.TotalListItemCost();
            }
           
            return checkout;
       }     
    }
}
