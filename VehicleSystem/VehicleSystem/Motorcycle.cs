using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem
{
    internal class Motorcycle : Vehicle
    {
        public bool  HasSideCar { get; set; }

        public Motorcycle( string make, string model, int year, bool hasSideCar)
            : base(make, model, year)
        {
            HasSideCar = hasSideCar;
            
        }



        //Override DisplayInfo

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine( HasSideCar ?  "This motorcyle has a sidecar" : "This motorcyle doesn't have a sidecar");
            }

        public void PerformWheelie()
        {

            Console.WriteLine("Performing a wheelie");

        }

    }
}
