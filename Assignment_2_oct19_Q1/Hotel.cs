﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oct19_Q1
{
    internal class Hotel:TourismDestination
    {
        
        public Hotel(string? hotelName, int availableRoom, string? name, string? country, double? rating):
            base(name, country, rating) 
        {
            HotelName = hotelName;
            AvailableRoom = availableRoom;
        }

        public string? HotelName { get; set; }
        public int AvailableRoom {  get; set; }

        public async Task HotelBookingig(int hotelRoom)
        {
         
            if( hotelRoom<=AvailableRoom)
            {
                await Task.Delay(2000);
                AvailableRoom =AvailableRoom-hotelRoom;

                Console.WriteLine("Hotel booked for:{0} \t Rooms left:{1}",HotelName, AvailableRoom);
            }
            else
            {
                await Console.Out.WriteLineAsync("All rooms are booked");
            }
        }
    }
}
