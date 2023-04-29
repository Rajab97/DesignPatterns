﻿using DesignPatterns.AbstractFactory.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Interfaces
{
    public interface IOrderManagementService
    {
        void OrderLivingRoomFurniture(FurnitureTypes furnitureTypes);
    }
}
