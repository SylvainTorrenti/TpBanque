using TpBanque;

Customer Customer1 = new Customer("Torrenti", "Sylvain");
Account Account1 = new Account(Customer1, 25000);
Account Account2 = new Account(Customer1);
Customer1.PrintAccountList();
//Account1.Credit(15000);
//Account1.Print();
//Account1.Debit(15000);
//Account1.Print();