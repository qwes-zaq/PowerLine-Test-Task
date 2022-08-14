using CSharpTask.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask.Cars
{
    public class PassengerCar : BaseCar
    {
        int _passengersNumber;
        public int PassengersNumber 
        {
            get => _passengersNumber;
            set 
            {
                if (value > 8 || value < 0)
                {
                    throw new Exception("Incorrect passengers number");
                }
                _passengersNumber = value;
            }
        }
        public PassengerCar(int averageFuelConsumption, int fuelTankVolume, int speed, int passengersNumber=0) 
            :base(averageFuelConsumption, fuelTankVolume, speed)
        {
            Type = VehicleType.PassengerCar;
            PassengersNumber = passengersNumber;
        }
        public override float TripDistance() => (base.TripDistance() * (100 - _passengersNumber * 6)) / 100;      
    }
}
