namespace PrimeiroProjeto
{
	public class Conta
	{
		public int Numero { get; private set; }
		public string Titular { get; set; }
		public double Saldo { get; private set; }
        private double TAXA_BANCARIA = 5.00;

        // Construtores:
        public Conta(int numero, string titular)
		{
			Numero = numero;
			Titular = titular;
			Saldo = 0.00;
		}

		public Conta(int numero, string titular, double depositoInicial) : this(numero, titular)
		{
			Depositar(depositoInicial);
		}

		// Outros métodos:
		public void Sacar(double valor)
		{
			if (valor > 0)
			{
                Saldo -= valor + TAXA_BANCARIA;
            }
			else
			{
				Console.WriteLine("Valor de saque inválido!");
			}
		}

		public void Depositar(double valor)
		{
            if (valor > 0)
            {
                Saldo += valor;
            }
            else
            {
                Console.WriteLine("Valor de depósito inválido!");
            }
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Titular + ", Saldo: $ " + Saldo.ToString("F2");
        }
    }
}

