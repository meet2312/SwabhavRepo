namespace InvoiceApp
{
    internal class Invoice
    {
        public int id;
        public string name,description;
        public double cost, tax;
        public float discount;
        public Invoice()
        {

        }

        public double CalcTotalCost()
        {
            double finalcost = ((cost - (cost*discount/100) + (cost*tax/100)));
            return finalcost;
        }
    }
}