using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpBanque
{
    internal class CurrentAccount : Account
    {
        /// <summary>
        /// Decouvert autorisé
        /// </summary>
        public int DiscoveryAuthorized { get; private set; }
        /// <summary>
        /// Constructeur 
        /// </summary>
        /// <param name="owner"></param>
        public CurrentAccount(Customer owner) : base(owner)
        {
            DiscoveryAuthorized = -300;
        }
        /// <summary>
        /// Constructeur avec solde
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="balance"></param>
        public CurrentAccount(Customer owner, double balance) : base(owner, balance)
        {
            DiscoveryAuthorized = -300;
        }
        /// <summary>
        /// Methode de débit override de celle de son parent
        /// </summary>
        /// <param name="debit"></param>
        /// <returns></returns>
        public override double Debit(int debit)
        {
            if ((Balance - debit) < DiscoveryAuthorized)
            {
                Console.WriteLine($"Le découvert autorisé est de {DiscoveryAuthorized} vous ne pouvez retirez autant!");
                Console.WriteLine("---------------------");
                return Balance;

            }
            return Balance = Balance - debit;

        }
        /// <summary>
        /// Methode pour augmenter le découvert
        /// </summary>
        /// <param name="discovery"></param>
        /// <returns></returns>
        public int AugmentDiscovery(int discovery)
        {
            Console.WriteLine(@$"
Le decouvert a était augmenté de {discovery} euros
---------------------
Le nouveau découvert est de {DiscoveryAuthorized - discovery} euros
---------------------");
            return DiscoveryAuthorized = DiscoveryAuthorized + discovery;
        }
        /// <summary>
        /// Methode d'affichage override de la classe Object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return @$"
Le numero du compte est {AccountNumber} fait le {CreationDate.ToString("dd/MM/yyyy")}
Le propriétaire est {Owner.Name} {Owner.FirstName}
Le solde est de {Balance}
Le découvert autorisé est de {DiscoveryAuthorized} euros
---------------------";
        }


    }
}
