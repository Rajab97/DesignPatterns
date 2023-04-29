using DesignPatterns.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Entities
{
    public class ModernChair : IChair
    {
        public void CreateChair()
        {
            Console.WriteLine("Modern Chair start to manufactuing");
            Thread.Sleep(2000);
            Console.WriteLine("Modern Chair ready for deliver");
        }

        public int GetNumberOfLegs()
        {
            return 1;
        }
    }
}
