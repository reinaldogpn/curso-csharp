using Course.Entities;
using Course.Services;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine()!);
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine()!);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine()!);

            Contract contract = new Contract(number, date, value);
            ContractService cs = new ContractService();
            cs.ProcessContract(contract, months);

            Console.WriteLine();
            Console.WriteLine("Installments:");

            foreach (var ins in contract.Installments)
            {
                Console.WriteLine(ins.ToString());
            }
        }

    }
}
