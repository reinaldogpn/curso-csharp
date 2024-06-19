using System.Globalization;
using Course.Entities;
using Course.Entities.Exceptions;

namespace Course;

class Program 
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int accNumber = int.Parse(Console.ReadLine()!);
            Console.Write("Holder: ");
            string? accHolder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double accBalance = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double accWLimit = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Account account = new Account(accNumber, accHolder!, accBalance, accWLimit);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            account.Withdraw(amount);

            Console.Write("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
        }
        catch (DomainException e)
        {
            Console.WriteLine("Withdraw error: " + e.Message);
        }
    }
}