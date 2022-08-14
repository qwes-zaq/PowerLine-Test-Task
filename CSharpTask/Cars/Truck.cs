using CSharpTask.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask.Cars
{
    public class Truck : BaseCar
    {
        private int _load;
        public int LoadCapacity { get; private set; }
        public int Load
        {
            get => _load;
            set 
            {
                if (value > LoadCapacity || value <= 0)
                {
                    throw new Exception("Incorrect load value");
                }
                _load = value;
            }
        }
        public Truck(int averageFuelConsumption, int fuelTankVolume, int speed, int loadCapacity, int load=0) 
            : base(averageFuelConsumption, fuelTankVolume, speed)
        {
            Type = VehicleType.Truck;
            LoadCapacity = loadCapacity;
            _load = load;
        }
        public override float TripDistance() => (base.TripDistance() * (100 - (_load * 4) / 200)) / 100;
    }
}
