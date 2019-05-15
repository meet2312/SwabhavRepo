using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerialDeserialization
{
    class Program
    {
       
        static void Main(string[] args)
        {
          
            Console.WriteLine("Before serialization the object contains: ");
            UserDetails ud = new UserDetails(1, "Manohar", "Hyderabad");
            ud.GetDetails();

                string fpath = @"E:\SwabhavRepository\OOP\Test.txt";

                // Check if file exists

                if (File.Exists(fpath))

                {
                    File.Delete(fpath);
                }

                Program p = new Program();
                p.DataSerialize();
                p.DataDeserialize();

            }

        public void DataSerialize()
        {
            string fpath = @"E:\SwabhavRepository\OOP\Test.txt";
            UserDetails ud = new UserDetails(2, "Manohar", "Bangalore");
            //Opens a file and serializes the object into it in binary format.
            //   UserDetails ud = new UserDetails(1, "Manohar", "Hyderabad");
            //     string fpath = @"E:\SwabhavRepository\OOP\Test.txt";
            Stream stream = File.Open(fpath, FileMode.Create);

            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(stream, ud);

            stream.Close();

            Console.WriteLine("\nSerialization Successful");

            Console.ReadLine();

        }

        // deserialize 
        public void DataDeserialize()
        {
            string fpath = @"E:\SwabhavRepository\OOP\Test.txt";
            UserDetails ud = new UserDetails(2, "Manohar", "Bangalore");
            //Opens file "Test.txt" and deserializes the object from it.
            //    Stream stream = File.Open(fpath, FileMode.Create);

            Stream   stream = File.Open(fpath, FileMode.Open);

            BinaryFormatter bf = new BinaryFormatter();

            ud = (UserDetails)bf.Deserialize(stream);

            stream.Close();

            Console.WriteLine("");

            Console.WriteLine("After deserialization the object contains: ");

            ud.GetDetails();

            Console.ReadLine();

        }

    }

        [Serializable()]

        public class UserDetails

        {

            public int userId { get; set; }

            public string userName { get; set; }

            public string location { get; set; }

            public UserDetails(int id, string name, string place)

            {

                userId = id;

                userName = name;

                location = place;

            }

            public void GetDetails()

            {

                Console.WriteLine("UserId: {0}", userId);

                Console.WriteLine("UserName: {0}", userName);

                Console.WriteLine("Location: {0}", location);

            }

        }


    }



