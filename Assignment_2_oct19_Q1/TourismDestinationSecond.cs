using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oct19_Q1
{
    internal class TourismDestinationSecond
    {
       public static List<TourismDestinationSecond> tourismDestinations = new List<TourismDestinationSecond>();
        public TourismDestinationSecond(string? name, string? location, double? rating, double pricePerNight)
        {
            Name = name;
            Location = location;
            Rating = rating;
            PricePerNight = pricePerNight;
        }

        public string? Name { get; set; }
        public string? Location { get; set; }
        public double? Rating { get; set; }
        public double PricePerNight { get; set; }

        public void TopRatedDestination(double rating)
        {
            var toprated=tourismDestinations.FindAll(x => x.Rating>rating);
            foreach(var item in toprated) {
                Console.WriteLine("Name:{0}\tCountry:{1}\tRating:{2}\tPrice Per Night:{3}", item.Name, item.Location, item.Rating,item.PricePerNight);
            }
        }
        public void SortingWithPrice()
        {
            Thread.Sleep(5000);
            var sortPrice = tourismDestinations.OrderBy(x => x.PricePerNight);
            foreach (var item in sortPrice)
            {
                Console.WriteLine("Name:{0}\tCountry:{1}\tRating:{2}\tPrice Per Night:{3}", item.Name, item.Location, item.Rating, item.PricePerNight);
            }
        }
        public void FilterWithCityName(string? cityName)
        {
            var filterList=tourismDestinations.FindAll(x=>x.Location==cityName);
            foreach (var item in filterList)
            {
                Console.WriteLine("Name:{0}\tCountry:{1}\tRating:{2}\tPrice Per Night:{3}", item.Name, item.Location, item.Rating, item.PricePerNight);
            }
        }
    }
}
