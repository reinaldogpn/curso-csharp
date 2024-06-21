using System;

namespace PrimeiroProjeto
{
	class Produto
	{
		// Atributos:
		private string _nome;
        public double Preco { get; private set; }
		public int Quantidade { get; private set; }

		// Construtores:
		public Produto()
        {
			// Ctor padrão
        }

		public Produto(string nome, double preco)
		{
            _nome = nome;
            Preco = preco;
            Quantidade = 5;
		}

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }

		// Properties:
		public string Nome
		{
			get
			{
				return _nome;
			}

			set
			{
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
		}

		// Outros métodos:
        public double ValorTotalEmEstoque()
		{
			return Quantidade * Quantidade;
		}

		public void AdicionarProdutos(int quantidade)
		{
            Quantidade += quantidade;
		}

		public void RemoverProdutos(int quantidade)
		{
            Quantidade -= quantidade;
		}

        public override string ToString()
        {
			return _nome + ", $" + Preco.ToString("F2") + ", " + Quantidade + " unidades, Total: $" + ValorTotalEmEstoque().ToString("F2");
        }
    }
}

