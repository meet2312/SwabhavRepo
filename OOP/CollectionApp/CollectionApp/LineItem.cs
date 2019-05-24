using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp
{
    class LineItem
    {
        private string _product;
        private double _cost;
        private int _quantity;

        public LineItem(string product,double cost,int quantity)
        {
            this._product = product;
            this._cost = cost;
            this._quantity = quantity;
        }

        public double CalculateTotalCost()
        {
            double total = _cost * _quantity;
            return total;
        }

        public override string ToString()
        {
            return "Product:" + _product + " Cost:" + _cost + " Quantity:" + _quantity;
        }

        public string Product
        {
            get
            {
                return _product;
            }
        }

        public double Cost
        {
            get
            {
                return _cost;
            }
        }

        public int Quantity
        {
            get
            {
                return _quantity;
            }
        }
    }
}
