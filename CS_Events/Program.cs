// See https://aka.ms/new-console-template for more information
using CS_Events.Models;

Console.WriteLine("Demo Events");
Banking bank = new Banking(50000);
// The Client has the Notification based subsctiption with bank
EventListener listener = new EventListener(bank);
bank.Deposit(70000);

Console.WriteLine($"After Deposit Net Balance = {bank.GetNetBalance()}");


bank.Withdrawal(117000);
Console.WriteLine($"After Withdrawal Net Balance = {bank.GetNetBalance()}");
Console.ReadLine();
