using System;

namespace TesteNetSafra
{
	class v_ConsultaOperacao
	{
		public long OperacaoId { get; set; }
		public DateTime OperacaoDataMovimento { get; set; }
		public decimal OperacaoQuantidade { get; set; }
		public decimal OperacaoValorPu { get; set; }
		public decimal OperacaoValorTotal { get; set; }

		public long ClienteId { get; set; }
		public String ClienteNome { get; set; }
		public String ClienteDocumento { get; set; }
	}
}

