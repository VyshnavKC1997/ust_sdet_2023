using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oct19_Q1
{
    internal class HotelEvent
    {
        public string? EventName { get; set; }
        public string? EventDate { get; set; }
        public string? Location { get; set; }
        public int Capacity { get; set; }


        public static void PrintRegisterationDetails(HotelEvent hotelEvent)
        {
            Console.WriteLine("Successfully Registered for the event {0} on {1} in {2}",hotelEvent.EventName,
                hotelEvent.EventDate,hotelEvent.Location);
        }
        public static void CapacityFull(HotelEvent hotelEvent)
        {
            Console.WriteLine("Capacity for Event {0} is full", hotelEvent.EventName);
        }
    }
}
