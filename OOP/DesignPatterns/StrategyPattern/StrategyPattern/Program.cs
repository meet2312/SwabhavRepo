using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select the mode of transport to get the travel time between source and destination: \nCar \nBike \nBus");  
    var userStrategy = Console.ReadLine().ToLower();  
    Console.WriteLine("\nUser has selected " + userStrategy + " as mode of transport\n");
            Console.WriteLine();
    switch (userStrategy) {  
        case "car":  
            new TravelStrategy(new CarStrategy()).GetTravelTime("Marines", "Worli");  
            break;  
        case "bike":  
            new TravelStrategy(new BikeStrategy()).GetTravelTime("Marines", "Worli");  
            break;  
        case "bus":  
            new TravelStrategy(new BusStrategy()).GetTravelTime("Marines", "Worli");  
            break;  
        default:  
            Console.WriteLine("You have chosen an invalid mode of transport.");  
            break;  
    }  
        }
    }
}
