using System;
using System.Collections.Specialized;

namespace NameValueCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name Value Collections!");

            // Creating
            Console.WriteLine("In Creating");

            NameValueCollection cities = new NameValueCollection();

            Console.WriteLine("------------");
            // Adding
            Console.WriteLine("In Adding");

            cities.Add("Germany", "Berlin");
            cities.Add("Germany", "Hamburg");
            cities.Add("Germany", "Frankfurt");
            cities.Add("Italy", "Rome");
            cities.Add("Italy", "Milan");

            Console.WriteLine("------------");
            // Displaying
            Console.WriteLine("In Displaying");

            foreach (string item in cities)
            {
                Console.Write("Country = " + item + " : ");
                Console.WriteLine(cities[item]);
            }
            Console.WriteLine("------------");
            // Set
            Console.WriteLine("In Setting");

            Console.WriteLine("Setting Italy to Venice");
            cities.Set("Italy", "Venice");

            foreach (string item in cities)
            {
                Console.Write("Country = " + item + " : ");
                Console.WriteLine(cities[item]);
            }

            Console.WriteLine("------------");
            // Contains
            Console.WriteLine("In Contains");

            Console.WriteLine("Checking to see if cities has keys = " + cities.HasKeys());
            
            Console.WriteLine("------------");
            // Remove
            Console.WriteLine("In Remove");

            Console.WriteLine("Removing Italy");
            cities.Remove("Italy");

            foreach (string item in cities)
            {
                Console.Write("Country = " + item + " : ");
                Console.WriteLine(cities[item]);
            }
            Console.WriteLine("------------");
            // Remove All
            Console.WriteLine("In Remove All");

            cities.Clear();
            foreach (string item in cities)
            {
                Console.Write("Country = " + item + " : ");
                Console.WriteLine(cities[item]);
            }

            Console.WriteLine("------------");
        }
    }
}
