namespace InvoiceEncapApp
{
    public class Invoice
    {
        private int id;
        private string name, description;
        private double cost, tax;
        private float discount;

        public int Id
        {
            get
            {
               return id ;
            }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public double Cost
        {
            get
            {
                return cost;
            }
            set
            {
                cost = value;
            }
        }

        public double Tax
        {
            get
            {
                return tax;
            }
            set
            {
                tax = value;
            }
        }

        public float Discount
        {
            get
            {
                return discount;
            }
            set
            {
                discount = value;
            }
        }
        public Invoice()
        {
        }

        public double CalcTotalAmt()
        {
            double finalcost = ((cost - (cost * discount / 100) + (cost * tax / 100)));
            return finalcost;
        }
    }
}