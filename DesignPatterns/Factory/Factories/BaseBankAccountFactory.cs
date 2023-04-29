using DesignPatterns.Factory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Factories
{
    public abstract class BaseBankAccountFactory
    {
        public abstract BankAcount CreateAccount(BankAccountTypes bankAccountTypes);
    }

    public enum BankAccountTypes
    {
        Personal,
        Business
    }
}
