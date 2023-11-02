﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oct19_Q1
{
    internal class Hotel:TourismDestination
    {
        int currentRoom=10;
        public Hotel(string? hotelName, int availableRoom, string? name, string? country, double? rating):
            base(name, country, rating) 
        {
            HotelName = hotelName;
            AvailableRoom = availableRoom;
        }

        public string? HotelName { get; set; }
        public int AvailableRoom {  get; set; }

        public async Task HotelBookingig(int hotelRoom,Hotel hotel)
        {
         
            if( hotelRoom<=currentRoom)
            {
                await Task.Delay(2000);
                currentRoom = currentRoom-hotelRoom;

                Console.WriteLine("Hotel booked for:{0} \t Rooms left:{1}",hotel.HotelName, currentRoom);
            }
            else
            {
                await Console.Out.WriteLineAsync("All rooms are booked");
            }
        }
    }
}
