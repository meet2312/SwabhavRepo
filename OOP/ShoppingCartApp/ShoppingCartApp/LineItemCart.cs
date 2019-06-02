using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
     class LineItemCart
    {
        private int _cartid, _quantity;
        private Product _product;

        public LineItemCart(int cartid, Product product, int quantity)
        {
            this._cartid = cartid;
            this._product = product;
            this._quantity = quantity;
        }

        public double TotalListItemCost()
        {
            double itemcost = _product.FindprodCost()*_quantity;
            return itemcost;
        }

        public int Cartid
        {
            get
            {
                return _cartid;
            }

        }

        public int Quantity
        {
            get
            {
                return _quantity;
            }

        }

        public Product Product
        {
            get
            {
                return _product;
            }
        }
    }
}
