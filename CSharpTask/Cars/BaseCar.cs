using CSharpTask.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask.Cars
{
    public abstract class BaseCar
    {
        public VehicleType Type { get; protected set; }
        public int AverageFuelConsumption { get; set; } // liter per 100 kilometers
        public int FuelTankVolume { get; set; }  // liters
        public int Speed { get; set; } //  kilometers per hour
        public virtual float TripDistance() => 100 * FuelTankVolume / AverageFuelConsumption; // Trip distance in km
        public virtual float TripTime() => TripDistance() / Speed; // Trip time in hours
        protected BaseCar(int averageFuelConsumption, int fuelTankVolume, int speed)
        {
            AverageFuelConsumption = averageFuelConsumption;
            FuelTankVolume = fuelTankVolume;
            Speed = speed;
        }
    }
}
