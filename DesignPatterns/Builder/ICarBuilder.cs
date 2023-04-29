using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public interface ICarBuilder<T> where T : class
    {
        void SetName(string name);
        void AddTransmission(string transmission);
        void AddVehicle(string vehicle);
        void AddAirCondition();
        void AddMonitor();
        void AddColor(string color);
        void AddMotorPower(decimal motorPower);
        T GetResult();
    }
}
