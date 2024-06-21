namespace Course.Services
{
    internal class PaypalService : IPaymentService
    {
        public PaypalService() { }

        public double PaymentFee(double amount)
        {
            return amount / 100 * 2;
        }

        public double Interest(double amount, int months)
        {
            return amount / 100 * months;
        }
    }
}
