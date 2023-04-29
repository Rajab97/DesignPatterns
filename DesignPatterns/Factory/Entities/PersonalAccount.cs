using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Entities
{
    public class PersonalAccount : BankAcount
    {
        public override void CheckIdentity()
        {
            Console.WriteLine("Personal account checked");
        }

        public override void RegisterAccount()
        {
            Console.WriteLine("Personal account registered");
        }
    }
}
