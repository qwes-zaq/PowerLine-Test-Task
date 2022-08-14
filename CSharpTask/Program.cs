using CSharpTask.Cars;
using System;
using System.Collections.Generic;

namespace CSharpTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BaseCar> carList = new();
            carList.Add(new PassengerCar(10, 10, 10, 2));
            carList.Add(new Truck(10, 10, 10, 1000, 400));
            carList.Add(new SportCar(10, 10, 100));

            foreach (var item in carList)
            {
                Console.WriteLine($"Type: {item.Type}");
                Console.WriteLine($"Distance: {item.TripDistance()} km");
                Console.WriteLine($"Speed: {item.Speed} km/h");
                Console.WriteLine($"Time: {item.TripTime()} h \n");
            }
        }
    }
}
