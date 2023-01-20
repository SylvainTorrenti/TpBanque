using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpBanque
{
    internal class Account
    {
        private static int NumberAccount = 0;

        public int AccountNumber { get; private set; }

        public Customer Owner { get; private set; }

        private DateTime CreationDate { get; set; }

        public double Balance { get; private set; }

        public Account(Customer owner)
        {
            NumberAccount += 1;
            Owner = owner;
            CreationDate = DateTime.Now;
            owner.AddAccount(this);
            AccountNumber = NumberAccount;
        }

        public Account(Customer owner, double balance)
        {
            NumberAccount += 1;
            Owner = owner;
            Balance = balance;
            CreationDate = DateTime.Now;
            owner.AddAccount(this);
            AccountNumber = NumberAccount;
        }

        public void Credit(int credit)
        {
            Balance = Balance + credit;
        }

        public void Debit(int debit)
        {
            Balance = Balance - debit;
        }

        public void Print()
        {
            Console.WriteLine(@$"
Le numero du compte est {AccountNumber} fait le {CreationDate.ToString("dd/MM/yyyy")}
Le propriétaire est {Owner.Name} {Owner.FirstName}
Le solde est de {Balance}");
        }


    }
}
