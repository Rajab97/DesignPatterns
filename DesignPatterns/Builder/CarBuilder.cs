using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class CarBuilder : ICarBuilder<Car>
    {
        private readonly Car _car;
        public CarBuilder()
        {
            _car = new Car();

        }
        public void AddAirCondition()
        {
            _car.IsAirConditionExist = true;
        }

        public void AddColor(string color)
        {
            _car.Color = color;
        }

        public void AddMonitor()
        {
            _car.IsMonitorExist = true;
        }

        public void AddMotorPower(decimal motorPower)
        {
          _car.MotorPower = motorPower;
        }

        public void AddTransmission(string transmission)
        {
            _car.Transmission = transmission;
        }

        public void AddVehicle(string vehicle)
        {
            _car.Vehicle = vehicle;
        }

        public Car GetResult()
        {
            return _car;
        }

        public void SetName(string name)
        {
            _car.Name = name;
        }
    }
}
