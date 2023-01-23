using TpBanque;

#region Account and Customer
Customer Customer1 = new Customer("Torrenti", "Sylvain");
//Account Account1 = new Account(Customer1, 25000);
//Customer1.PrintAccountList();
//Account1.Credit(15000);
//Console.WriteLine(Account1.ToString());
//Account1.Debit(15000);
//Console.WriteLine(Account1.ToString());
#endregion
#region Current Account
CurrentAccount CurAc1 = new CurrentAccount(Customer1);
//Console.WriteLine(CurAc1.ToString());
//CurAc1.Debit(400);
//Console.WriteLine(CurAc1.ToString());
//CurAc1.AugmentDiscovery(1500);
#endregion
#region Saving Account
SavingsAccount SavAc1 = new SavingsAccount(Customer1, 9850);
//Console.WriteLine(SavAc1.ToString());
//SavAc1.CalculInterest();
//Console.WriteLine(SavAc1.ToString());
//SavAc1.AddInterest();
//Console.WriteLine(SavAc1.ToString());
//SavAc1.Debit(18000);
//Console.WriteLine(SavAc1.ToString());
#endregion