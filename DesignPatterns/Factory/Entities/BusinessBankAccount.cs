using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Entities
{
    public class BusinessBankAccount : BankAcount
    {
        public override void CheckIdentity()
        {
            Console.WriteLine("Business account checked");
        }

        public override void RegisterAccount()
        {
            Console.WriteLine("Business account registered");
        }
    }
}
