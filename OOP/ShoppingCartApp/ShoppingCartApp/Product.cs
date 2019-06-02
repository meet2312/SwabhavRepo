using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    class Product
    {
        private int _productid;
        private string _productname;
        private double _productcost, _discount;

        public int Productid
        {
            get
            {
                return _productid;
            }

        }

        public string Productname
        {
            get
            {
                return _productname;
            }
        }

        public double Productcost
        {
            get
            {
                return _productcost;
            }

        }

        public double Discount
        {
            get
            {
                return _discount;
            }

        }

        public double FindprodCost()
        {
            double cost = _productcost - _discount;
            return cost;
        }

        public Product(int productid,string productname,double productcost,double discount)
        {
            this._productid = productid;
            this._productname = productname;
            this._productcost = productcost;
            this._discount = discount;
        } 
    }
}
