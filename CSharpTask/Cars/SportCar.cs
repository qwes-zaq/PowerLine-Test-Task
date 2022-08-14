using CSharpTask.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask.Cars
{
    public class SportCar : BaseCar
    {
        public SportCar(int averageFuelConsumption, int fuelTankVolume, int speed) 
            : base(averageFuelConsumption, fuelTankVolume, speed)
        {
            Type = VehicleType.SportCar;
        }
    }
}
