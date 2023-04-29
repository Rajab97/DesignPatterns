using DesignPatterns.Factory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Factories
{
    public class ForeignBankAccountFactory : BaseBankAccountFactory
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
                            AccountNumber = "FP156623231",
                            Balance = 125
                        };
                        break;

                    }
                case BankAccountTypes.Business:
                    {
                        bankAcount = new BusinessBankAccount()
                        {
                            AccountNumber = "FB4588458845",
                            Balance = 200
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
