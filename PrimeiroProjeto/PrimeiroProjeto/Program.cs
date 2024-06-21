namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta novaConta = null;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char escolha = char.Parse(Console.ReadLine());

            if (escolha == 's' || escolha == 'S')
            {
                Console.Write("Entre o valor para depósito inicial: ");
                double deposito = double.Parse(Console.ReadLine());

                novaConta = new Conta(numero, titular, deposito);
            }
            else
            {
                novaConta = new Conta(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(novaConta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine());
            novaConta.Depositar(valor);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(novaConta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine());
            novaConta.Sacar(valor);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(novaConta);
        }
    }
}