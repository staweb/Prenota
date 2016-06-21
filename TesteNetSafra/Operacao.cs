using System;

namespace TesteNetSafra
{
	class Operacao
	{
		public Operacao(long id, Cliente cli = null)
		{
			Id = id;
			IdCliente = cli == null ? 0 : cli.Id;
			DataMovimento = DateTime.Now;
			Quantidade = new Random(1).Next();
			ValorPu = new Random(10).Next();
			ValorTotal = Quantidade*ValorPu;
		}

		public long Id { get; set; }
		public long IdCliente { get; set; }
		public DateTime DataMovimento { get; set; }
		public decimal Quantidade { get; set; }
		public decimal ValorPu { get; set; }
		public decimal ValorTotal { get; set; }
	}
}

