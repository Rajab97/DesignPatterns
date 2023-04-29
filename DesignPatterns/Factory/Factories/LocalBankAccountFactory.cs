using DesignPatterns.Factory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Factories
{
    public class LocalBankAccountFactory : BaseBankAccountFactory
    {
        public override BankAcount CreateAccount(BankAccountTypes bankAccountTypes)
        {
            BankAcount bankAcount = null;
            switch (bankAccountTypes)
            {
                case BankAccountTypes.Personal:
                    {
                        bankAcount = new PersonalAccount()
                        {
                            AccountNumber = "P156623231",
                            Balance = 525
                        };
                        break;

                    }
                case BankAccountTypes.Business:
                    {
                        bankAcount = new BusinessBankAccount()
                        {
                            AccountNumber = "B1256236",
                            Balance = 400
                        };
                        break;

                    }
                default:
                    throw new ApplicationException($"Implementation not exist for {bankAccountTypes.ToString()}");
            }
            return bankAcount;
        }
    }
}
