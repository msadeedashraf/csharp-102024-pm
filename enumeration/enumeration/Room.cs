using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumeration
{
    public enum RoomStatus
    {
        Available,   // Room is available for booking
        Occupied,    // Room is currently booked
        Maintenance, // Room is under maintenance
        Cleaning     // Room is being cleaned

    }


    internal class Room
    {

        public int RoomNumber { get; set; }
        public RoomStatus Status { get; set; }


        public void DisplayStatus()
        {
            Console.WriteLine($"Room {RoomNumber} is currently {Status}");

        }

        public void ChangeStatus(RoomStatus newStatus)
        {
            Status = newStatus;

        }


    }
}
