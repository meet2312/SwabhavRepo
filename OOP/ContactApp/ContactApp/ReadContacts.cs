using System.IO;

namespace ContactApp
{
     class ReadContacts
    {
        public void ReadContent()
        {
            string text = File.ReadAllText((@"E:\SwabhavRepository\OOP\ContactApp\Contact.txt"));

            // Display the file contents to the console. Variable text is a string.
            System.Console.WriteLine("Contacts: {0}", text);

        }
    }
}