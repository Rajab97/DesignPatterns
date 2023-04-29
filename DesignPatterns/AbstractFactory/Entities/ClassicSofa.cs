using DesignPatterns.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Entities
{
    public class ClassicSofa : ISofa
    {
        public void CreateSofa()
        {
            Console.WriteLine("Classic Sofa start to manufactuing");
            Thread.Sleep(2000);
            Console.WriteLine("Classic Sofa ready for deliver");
        }

        public decimal GetWeight()
        {
            return 5.4M;
        }
    }
}
