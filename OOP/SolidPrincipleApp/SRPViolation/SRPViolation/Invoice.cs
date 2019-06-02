using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPViolation
{
    class Invoice
    {
        private int _invoiceno;
        private string _invoicename;
        private double _cost;
        private float _discount;
        private float _gst;

        public int Invoiceno
        {
            get
            {
                return _invoiceno;
            }

        }

        public string Invoicename
        {
            get
            {
                return _invoicename;
            }

        }

        public double Cost
        {
            get
            {
                return _cost;
            }

        }

        public Invoice(int invoiceno,string invoicename,double cost,float discount,float gst)
        {
            this._invoiceno = invoiceno;
            this._invoicename = invoicename;
            this._cost = cost;
            this._discount = discount;
            this._gst = gst;
        }

        public float CalculateDiscount()
        {
            double disc = _cost - (_cost * _discount);
            return (float)disc;
        }

        public float CalculateGST()
        {
            double gst = _cost + (_cost * _gst);
            return (float)gst;
        }

        public float CalculateTotalCost()
        {
            double finalcost = CalculateDiscount() + CalculateGST();
            return (float)finalcost;
        }

        public void PrintInvoice()
        {
            Console.WriteLine("Invoice no: "+Invoiceno+"Invoice name: "+Invoicename+"Discount : "+CalculateDiscount()+"Gst :"+CalculateGST()+"Total cost:"+CalculateTotalCost());
        }
    }
}
