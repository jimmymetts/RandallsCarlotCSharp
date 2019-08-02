using System;
using System.Collections.Generic;

namespace RandallsCarlotCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Dictionary<string, string> vehicles = new Dictionary<string, string>();
            {
                // Add several more words and their definitions
                vehicles.Add("Awesome", "The feeling of students when they are learning C#");
                vehicles.Add("foolk", "a musician from Slovakia. Weird jazz, electronica and hip-hop#");
                vehicles.Add("Jazz Finger", "to show off in an unecessary fashion");
            };
            foreach (KeyValuePair<string, string> word in vehicles)
            {
                Console.WriteLine($"The definition of {word.Key} is {word.Value}");
            }
        }

    }
}
