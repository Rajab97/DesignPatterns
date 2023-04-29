using DesignPatterns.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Entities
{
    public class ClassicChair : IChair
    {
        public void CreateChair()
        {
            Console.WriteLine("Classic chair start to manufactuing");
            Thread.Sleep(2000);
            Console.WriteLine("Classic chair ready for deliver");
        }

        public int GetNumberOfLegs()
        {
            return 4;
        }
    }
}
