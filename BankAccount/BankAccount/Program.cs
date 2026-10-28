using Bank_Account;

BankAccount b1 = new BankAccount("Ali Hassan", "100001");
b1.Deposit(5000);
b1.Withdraw(1200);
Console.WriteLine(b1.ToString());

try {
    b1.Withdraw(10000);
}
catch (Exception ex) {
    Console.WriteLine($"Error: {ex.Message}");
}
Console.WriteLine($"Balance {b1.Balance}");




