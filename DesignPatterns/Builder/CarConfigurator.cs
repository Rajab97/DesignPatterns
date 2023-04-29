using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class CarConfigurator
    {
        private readonly ICarBuilder<Car> _carBuilder;

        public CarConfigurator(ICarBuilder<Car> carBuilder)
        {
            _carBuilder = carBuilder;
        }

        public Car CraeteMercedesBenzC200()
        {
            _carBuilder.AddVehicle("V350");
            _carBuilder.AddTransmission("Aoto");
            _carBuilder.AddMotorPower(3.5M);
            _carBuilder.AddAirCondition();
            _carBuilder.SetName("MercedesBenzC200");
            return _carBuilder.GetResult();
        }

        public Car CraeteMercedesBenzE450BalckEdition()
        {
            _carBuilder.AddVehicle("V450");
            _carBuilder.AddTransmission("Aoto");
            _carBuilder.AddMotorPower(4.5M);
            _carBuilder.AddAirCondition();
            _carBuilder.AddColor("Black");
            _carBuilder.AddMonitor();
            _carBuilder.SetName("MercedesBenzE450BalckEdition");
            return _carBuilder.GetResult();
        }
    }
}
