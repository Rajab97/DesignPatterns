using DesignPatterns.AbstractFactory.Constants;
using DesignPatterns.AbstractFactory.Factories;
using DesignPatterns.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Concretes
{
    public class OrderManagementService : IOrderManagementService
    {
        private readonly IFactoryBuilder<FurnitureTypes, BaseFurnitureFactory> _factoryBuilder;

        public OrderManagementService(IFactoryBuilder<FurnitureTypes,BaseFurnitureFactory> factoryBuilder)
        {
            _factoryBuilder = factoryBuilder;
        }
        public void OrderLivingRoomFurniture(FurnitureTypes furnitureTypes)
        {
            var factory = _factoryBuilder.CreateFactory(furnitureTypes);
            factory.GetChair().CreateChair();
            factory.GetSofa().CreateSofa();
        }
    }
}
