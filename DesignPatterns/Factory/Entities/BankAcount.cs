using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Entities
{
    public abstract class BankAcount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public abstract void CheckIdentity();
        public abstract void RegisterAccount();
    }
}
