using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpBanque
{
    internal class Customer
    {
        /// <summary>
        /// Nom
        /// </summary>
        public string Name { get;  private set; }
        /// <summary>
        /// Prenom
        /// </summary>
        public string FirstName { get; private set; }
        /// <summary>
        /// Liste des comptes
        /// </summary>
        private List<Account> _accounts = new List<Account>();
        /// <summary>
        /// Consrtructeur
        /// </summary>
        /// <param name="name"></param>
        /// <param name="firstName"></param>
        public Customer(string name, string firstName)
        {
            Name = name;
            FirstName = firstName;
        }
        /// <summary>
        /// Methode pour ajouter un compte
        /// </summary>
        /// <param name="account"></param>
        public void AddAccount(Account account)
        {
            _accounts.Add(account);
        }
        /// <summary>
        /// Methode pour afficher la liste des compte
        /// </summary>
        public void PrintAccountList()
        {
            foreach (Account account in _accounts)
            {
                account.ToString();
            }
        }
    }
}
