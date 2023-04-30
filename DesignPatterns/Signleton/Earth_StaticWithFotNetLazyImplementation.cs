using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{


    public sealed class Earth_StaticWithFotNetLazyImplementation
    {
        public decimal Radius { get; set; }
        public decimal Weight { get; set; }


        public static void SetRadius(decimal radius)
        {
            Instance.Radius = radius;
        }
        public static void SetWeight(decimal weight)
        {
            Instance.Weight = weight;
        }
        static Earth_StaticWithFotNetLazyImplementation() { }
        private Earth_StaticWithFotNetLazyImplementation() { }

        private static Lazy<Earth_StaticWithFotNetLazyImplementation> _instance = new Lazy<Earth_StaticWithFotNetLazyImplementation>(()=> new Earth_StaticWithFotNetLazyImplementation());

        public static Earth_StaticWithFotNetLazyImplementation Instance { get { return _instance.Value; } }
        public override string ToString()
        {
            return $"Weight:{Instance.Weight}, Radius:{Instance.Radius}";
        }
    }
}
