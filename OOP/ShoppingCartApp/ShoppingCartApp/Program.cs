using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Product product1 = new Product(1, "mobile", 10000, 1000);
            Product product2 = new Product(2, "case", 500, 50);
            Product product3 = new Product(3, "laptop", 35000, 1500);

            LineItemCart cart1 = new LineItemCart(11, product1, 1);
            LineItemCart cart2 = new LineItemCart(22, product2, 3);

            Order order1 = new Order(21,DateTime.Now);
            Order order2 = new Order(22, DateTime.Now);

            order1.AddItem(cart1);
            order1.AddItem(cart2);

            order2.AddItem(cart2);
           
            Customer customer = new Customer("xyz",order1);
            customer.AddOrder(order1);
            customer.AddOrder(order2);
          //  customer.OrderDetails();
            PrintOrderDetails(customer);
            //PrintOrderDetails("xyz");
           // Console.WriteLine("Final CheckoutCost :{0}", order1.CheckoutCost());
           // Console.WriteLine("Final CheckoutCost :{0}", order2.CheckoutCost());
            //  Console.WriteLine("Cart Product cost for " + product1.Productname + " with quantity " +cart1.Quantity+ " is :{0}", cart1.TotalListItemCost());
            //    Console.WriteLine("Cart Product cost for " + product2.Productname + " with quantity " + cart2.Quantity + " is :{0}", cart2.TotalListItemCost());



            //  double pcost= product1.FindprodCost();
            //  Console.WriteLine("Product cost for "+product1.Productname+":{0}",product1.FindprodCost());
            //  Console.WriteLine("Product cost for " + product2.Productname + ":{0}", product2.FindprodCost());
            //  Console.WriteLine("Product cost for " + product3.Productname + ":{0}", product3.FindprodCost());
        }

        private static void PrintOrderDetails(Customer c)
        {
            Console.WriteLine("Customer name:{0}",c.Customername);
            c.OrderDetails();
            Console.WriteLine("Product summary:{0}", c.Finalcart);
        }
    }
}
