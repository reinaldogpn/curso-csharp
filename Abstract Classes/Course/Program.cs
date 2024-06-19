using System.Globalization;
using Course.Entities;

namespace Course;

class Program 
{
    static void Main() 
    {
        Console.Write("Enter the number of tax payers: ");
        int taxPayers = int.Parse(Console.ReadLine());
        List<TaxPayer> taxesPayers = [];

        for (int i = 1; i <= taxPayers; i++)
        {
            Console.WriteLine($"Tax payer #{i} data:");
            Console.Write("Individual or company (i/c)? ");
            char type = char.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Anual income: ");
            double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (type == 'i') 
            {
                Console.Write("Health expenditures: ");
                double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Individual individual = new Individual(name, income, healthExpenditures);
                taxesPayers.Add(individual);
            }
            else if (type == 'c')
            {
                Console.Write("Number of employees: ");
                int employeesNumber = int.Parse(Console.ReadLine());

                Company company = new Company(name, income, employeesNumber);
                taxesPayers.Add(company);
            }
            else
            {
                Console.WriteLine("Tipo de contribuinte inválido!");
                return;
            }

            Console.WriteLine();
        }

        Console.WriteLine("TAXES PAID:");

        foreach (TaxPayer taxPayer in taxesPayers)
        {
            Console.WriteLine(taxPayer.Name + ": $ " + taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture));
        }

        Console.WriteLine();
        Console.WriteLine("TOTAL TAXES: " + TaxesSum(taxesPayers).ToString("F2", CultureInfo.InvariantCulture));
    }

    static double TaxesSum(List<TaxPayer> taxPayers)
    {
        double sum = 0.0;

        foreach (TaxPayer taxPayer in taxPayers)
        {
            sum += taxPayer.Tax();
        }

        return sum;
    }
}