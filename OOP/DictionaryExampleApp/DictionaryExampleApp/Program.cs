using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Int16> AuthorList = new Dictionary<string, Int16>();
            AuthorList.Add("Mahesh Chand", 35);
            AuthorList.Add("Mike Gold", 25);
            AuthorList.Add("Praveen Kumar", 29);
            AuthorList.Add("Raj Beniwal", 21);
            AuthorList.Add("Dinesh Beniwal", 84);
            // Count    
            Console.WriteLine("Count: {0}", AuthorList.Count);
            // Set Item value    
          //  AuthorList["Neel Beniwal"] = 9;
            if (!AuthorList.ContainsKey("Maheshyyy Chand"))
            {
                AuthorList["Mahesh Chand"] = 20;
            }
           
            // Read all items    
            Console.WriteLine("Authors all items:");
            foreach (KeyValuePair<string, Int16> author in AuthorList)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                author.Key, author.Value);
            }
            // Remove item with key = 'Mahesh Chand'    
            AuthorList.Remove("Mahesh Chand");
            Console.WriteLine("After removing");
            foreach (KeyValuePair<string, Int16> author in AuthorList)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                author.Key, author.Value);
            }
            // Remove all items    
            AuthorList.Clear();
        }
    }
}
