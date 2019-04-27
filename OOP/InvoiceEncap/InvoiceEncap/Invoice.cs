using System;

namespace InvoiceEncap
{
    public class Invoice
    {
        private int id;
        private string name, description;
        private double cost, tax;
        private float discount;

        public void SetId(int idd)
        {
            id = idd;
        }
        public void SetName(string namee)
        {
            name = namee;
        }
        public void SetDescription(string desc)
        {
            description = desc;
        }
        public void SetCost(double costt)
        {
            if (costt > 0)
            {
                cost = costt;
            }
            else
            {
                cost = 1;
            }
        }
        public void SetDiscount(float disc)
        {
            discount = disc;
        }
        public void SetTax(double taxx)
        {
            tax = taxx;
        }
        public int GetId()
        {
            return id;
        }
        public string GetName()
        {
            return name;
        }
        public string GetDescription()
        {
            return description;
        }
        public float GetDiscount()
        {
            return discount;
        }
        public double GetCost()
        { 
            return cost;
        }
        public double GetTax()
        {
            return tax;
        }

        public double CalcTotalCost()
        {
            double finalcost = ((cost - (cost * discount / 100) + (cost * tax / 100)));
            return finalcost;
        }
    }
}