using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Interfaces
{
    public interface IFactoryBuilder<TCondition,TResult> where TResult : class
    {
        TResult CreateFactory(TCondition condition);
    }
}
