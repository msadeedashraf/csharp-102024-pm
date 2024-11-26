using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem
{
    internal class Vehicle
    {
        //Properties
        public string Make { get; set; }
        public string  Model { get; set; }
        public int  Year { get; set; }

        //Constructor
        public Vehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
            
        }

        //Method to display details
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Vehicle: {Year} {Make} {Model}");
        
        }

        public void Honk()
        {
            Console.WriteLine("Car says ppppppp");

        }


    }
}
