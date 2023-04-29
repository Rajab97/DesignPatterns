using DesignPatterns.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Factories
{
    public abstract class BaseFurnitureFactory
    {
        public abstract IChair GetChair();
        public abstract ISofa GetSofa();
    }
}
