using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpBanque
{
    internal class Customer
    {
        public string Name { get;  private set; }

        public string FirstName { get; private set; }

        private List<Account> _accounts = new List<Account>();

        public Customer(string name, string firstName)
        {
            Name = name;
            FirstName = firstName;
        }

        public void AddAccount(Account account)
        {
            _accounts.Add(account);
        }
        public void PrintAccountList()
        {
            foreach (Account account in _accounts)
            {
                account.Print();
            }
        }
    }
}
