using Course.Entities;

namespace Course.Services
{
    internal class ContractService
    {
        private PaypalService paypalService = new PaypalService();

        public ContractService() { }

        public void ProcessContract (Contract contract, int months)
        {
            for (int i = 1; i <= months; i++)
            {
                double insValue = contract.TotalValue / months;
                double amount = insValue + paypalService.Interest(insValue, i);
                amount += paypalService.PaymentFee(amount);

                Installment installment = new Installment(contract.Date.AddMonths(i), amount);

                contract.AddInstallment(installment);
            }
        }
    }
}
