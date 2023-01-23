using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpBanque
{
    internal abstract class Account
    {
        /// <summary>
        /// Nombre de compte créé
        /// </summary>
        private static int NumberAccount = 0;
        /// <summary>
        /// numero du compte
        /// </summary>
        public int AccountNumber { get; protected set; }
        /// <summary>
        /// Propriétaire
        /// </summary>
        public Customer Owner { get; protected set; }
        /// <summary>
        /// Date de creation
        /// </summary>
        public DateTime CreationDate { get; protected set; }
        /// <summary>
        /// Solde
        /// </summary>
        public double Balance { get; protected set; }
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="owner"></param>
        public Account(Customer owner)
        {
            NumberAccount += 1;
            Owner = owner;
            CreationDate = DateTime.Now;
            owner.AddAccount(this);
            AccountNumber = NumberAccount;
        }
        /// <summary>
        /// Constructeur avec solde
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="balance"></param>
        public Account(Customer owner, double balance)
        {
            NumberAccount += 1;
            Owner = owner;
            Balance = balance;
            CreationDate = DateTime.Now;
            owner.AddAccount(this);
            AccountNumber = NumberAccount;
        }
        /// <summary>
        /// Methode pour credité
        /// </summary>
        /// <param name="credit"></param>
        /// <returns></returns>
        public virtual double Credit(int credit)
        {
            return Balance = Balance + credit;
        }
        /// <summary>
        /// Methode pour debité
        /// </summary>
        /// <param name="debit"></param>
        /// <returns></returns>
        public virtual double Debit(int debit)
        {
            return Balance = Balance - debit;
        }
        /// <summary>
        /// Methode pour afficher override de la classe Object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return@$"
Le numero du compte est {AccountNumber} fait le {CreationDate.ToString("dd/MM/yyyy")}
Le propriétaire est {Owner.Name} {Owner.FirstName}
Le solde est de {Balance} euros
---------------------";
        }
    }
}
