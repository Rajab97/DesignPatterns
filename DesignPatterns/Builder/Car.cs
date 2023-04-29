using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class Car
    {
        public string Name { get; set; }
        public string Vehicle { get; set; }
        public string Transmission { get; set; }
        public string Color { get; set; }
        public bool IsAirConditionExist { get; set; }
        public bool IsMonitorExist { get; set; }
        public decimal MotorPower { get; set; }

        public override string ToString()
        {
            return $"{Name} - Vehicle({Vehicle} - Transmission({Transmission}) - Color({Color}))";
        }
    }
}
