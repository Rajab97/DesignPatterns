using DesignPatterns.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Entities
{
    public class ModernSofa : ISofa
    {
        public void CreateSofa()
        {
            Console.WriteLine("Modern Sofa start to manufactuing");
            Thread.Sleep(2000);
            Console.WriteLine("Modern Sofa ready for deliver");
        }

        public decimal GetWeight()
        {
            return 3.6M;
        }
    }
}
