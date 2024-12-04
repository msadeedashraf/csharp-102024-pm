using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumeration
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Room room101 = new Room
            {
                RoomNumber = 101,
                Status = RoomStatus.Available
            };

            room101.DisplayStatus();

            room101.ChangeStatus(RoomStatus.Cleaning);

            room101.DisplayStatus();

            Console.ReadLine();

        }
    }
}
