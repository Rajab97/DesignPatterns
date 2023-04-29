using DesignPatterns.AbstractFactory.Entities;
using DesignPatterns.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Factories
{
    public class ClassicFurnitureFactory : BaseFurnitureFactory
    {
        public override IChair GetChair()
        {
            return new ClassicChair();
        }

        public override ISofa GetSofa()
        {
           return new ClassicSofa();
        }
    }
}
