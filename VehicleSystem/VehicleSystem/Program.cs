using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //Create a Car instance
            Car firstCar = new Car("Toyota", "Corolla", 2023, 4);
            firstCar.DisplayInfo();
            firstCar.PlayMusic();


            Car secondCar = new Car("Honda", "CR-V", 2025, 4);
            secondCar.DisplayInfo();
            secondCar.Honk();

            //Create the motorcycle instance
            Motorcycle firstMotorCycle = new Motorcycle("Honda","Sports",2019,true);

            firstMotorCycle.DisplayInfo();
            firstMotorCycle.PerformWheelie();


            Console.ReadLine();
        }
    }
}
