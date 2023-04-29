using DesignPatterns.AbstractFactory.Entities;
using DesignPatterns.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Factories
{
    public class ModernFurnitureFactory : BaseFurnitureFactory
    {
        public override IChair GetChair()
        {
            return new ModernChair();
        }

        public override ISofa GetSofa()
        {
            return new ModernSofa();
        }
    }
}
