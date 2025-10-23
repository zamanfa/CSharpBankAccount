using BankAccountLibrary;

Account account = new Account("Savings", 10000, "12345678765432");

Console.WriteLine("Account view");
Console.WriteLine(account.ToString());

account.Debit(3000);
Console.WriteLine($"\nAfter debiting 3000: {account.AccountBalance}");

account.Debit(-1000);
Console.WriteLine($"\nAfter debiting -1000: {account.AccountBalance}");

account.Credit(5000);
Console.WriteLine($"\nAfter crediting 5000: {account.AccountBalance}");