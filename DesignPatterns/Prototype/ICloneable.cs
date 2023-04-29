﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    public interface ICloneable<T> where T : class
    {
        T Clone();
    }
}
