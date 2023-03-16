using System;
using System.Globalization;
namespace Gorod
{
    class Program
    {
        static void Main(string[] args)
        {
            var city = new City();
            city.Name = "Ekaterinburg";
            city.Location = new GeoLocation();
            city.Location.Latitude = 56.50;
            city.Location.Longitude = 60.35;
            Console.WriteLine($"I love {city.Name} located at ({city.Location.Latitude} , {city.Location.Longitude})");
            city.Location.Longitude.ToString(CultureInfo.InvariantCulture);
            city.Location.Latitude.ToString(CultureInfo.InvariantCulture);
        }
    }
}
