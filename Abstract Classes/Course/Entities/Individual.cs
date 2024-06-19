namespace Course.Entities;

class Individual : TaxPayer
{
    public double HealthExpenditures { get; set; }

    public Individual()
    {
    }

    public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
    {
        HealthExpenditures = healthExpenditures;
    }

    public override double Tax()
    {
        double taxes;

        if (AnualIncome < 20000.00)
        {
            taxes = AnualIncome / 100 * 15;
        }
        else
        {
            taxes = AnualIncome / 100 * 25;
        }

        if (HealthExpenditures > 0.00) 
        {
            taxes -= HealthExpenditures / 100 * 50;
        }

        return taxes;
    }
}
