using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpBanque
{
    internal class SavingsAccount : Account
    {
        /// <summary>
        /// Solde minimum
        /// </summary>
        public int MinimumBalance { get; private set; }
        /// <summary>
        /// Intérêt
        /// </summary>
        public double Interest { get; private set; }
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="owner"></param>
        public SavingsAccount(Customer owner) : base(owner)
        {
            MinimumBalance = 150;
            Balance = 150;
            Interest = 0.75;

        }
        /// <summary>
        /// Constructeur avec solde
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="balance"></param>
        public SavingsAccount(Customer owner, double balance) : base(owner, balance)
        {
            MinimumBalance = 150;
            Balance = balance + MinimumBalance;
            Interest = 0.75;
        }
        /// <summary>
        /// Method pour calculer les intérêt
        /// </summary>
        /// <returns></returns>
        public double CalculInterest()
        {
            return Balance * Interest;
        }
        /// <summary>
        /// Methode pour ajouter les intérêt
        /// </summary>
        /// <returns></returns>
        public double AddInterest()
        {
            return Balance = CalculInterest() + Balance;
        }
        /// <summary>
        /// Methos de debit override
        /// </summary>
        /// <param name="debit"></param>
        /// <returns></returns>
        public override double Debit(int debit)
        {
            if ((Balance - debit) < MinimumBalance)
            {
                Console.WriteLine($"Le solde minimum autorisé est de {MinimumBalance} euros vous ne pouvez retirez autant!");
                Console.WriteLine("---------------------");
                return Balance;

            }
            return base.Debit(debit);
        }
        /// <summary>
        /// Methode pour afficher override de la classe Object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return @$"
Le numero du compte est {AccountNumber} fait le {CreationDate.ToString("dd/MM/yyyy")}
Le propriétaire est {Owner.Name} {Owner.FirstName}
Le solde est de {Balance} euros
Le taux d'intérêt est de {Interest}%
---------------------";

        }


    }
}
