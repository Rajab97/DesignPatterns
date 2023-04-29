using DesignPatterns.Factory.Entities;
using DesignPatterns.Factory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class AccountService : IAccountService
    {
        private readonly BaseBankAccountFactory _bankAccountFActory;

        public AccountService(BaseBankAccountFactory bankAccountFActory)
        {
            _bankAccountFActory = bankAccountFActory;
        }

        public BusinessBankAccount? RegisterBusinessAccount()
        {
            var bankAccount = _bankAccountFActory.CreateAccount(BankAccountTypes.Business);
            return bankAccount as BusinessBankAccount;
        }
        public PersonalAccount? RegisterPersonalAccount()
        {
            var personalAccount = _bankAccountFActory.CreateAccount(BankAccountTypes.Personal);
            return personalAccount as PersonalAccount;
        }
    }
}
