namespace Course.Entities;

class Company : TaxPayer
{
    public int EmployeesNumber { get; set; }

    public Company()
    {
    }

    public Company(string name, double anualIncome, int employeesNumber) : base(name, anualIncome)
    {
        EmployeesNumber = employeesNumber;
    }

    public override double Tax()
    {
        if (EmployeesNumber <= 10)
        {
            return AnualIncome / 100 * 16;
        }
        else
        {
            return AnualIncome / 100 * 14;
        }
    }
}
