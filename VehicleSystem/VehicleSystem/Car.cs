using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem
{
    internal class Car : Vehicle
    {
        //Properties
        public int NumberOfDoors { get; set; }

        //Constructor
       
        public Car(string make , string model, int year, int numberOfDoors)
            :base(  make, model, year)
        {
                NumberOfDoors = numberOfDoors;
        }
        //Overriding vs Overloading
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"This car has {NumberOfDoors} doors");

        }

        public void PlayMusic()
        {
            Console.WriteLine("Playing music in the car");

        }

       






    }
}
