using DesignPatterns.AbstractFactory.Constants;
using DesignPatterns.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Factories
{
    public class FurnitureFactoryBuilder : IFactoryBuilder<FurnitureTypes,BaseFurnitureFactory>
    {
        public BaseFurnitureFactory CreateFactory(FurnitureTypes condition)
        {
            switch(condition)
            {
                case FurnitureTypes.Classic: return new ClassicFurnitureFactory();
                case FurnitureTypes.Modern: return new ModernFurnitureFactory();
                default: throw new NotImplementedException($"Factory for {condition} not implemented");
            }  
                    
        }
    }
}
