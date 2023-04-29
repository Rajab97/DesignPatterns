using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Constants
{
    public static class EnumTypeHelper
    {
        public static FurnitureTypes GetFurnitureTypeByChar(char symbol)
        {
            if (symbol == 'M')
                return FurnitureTypes.Modern;
            else if (symbol == 'C')
                return FurnitureTypes.Classic;
            else
                throw new ArgumentException($"Furniture type not exist for this symbol {symbol}");
        }
    }
}
