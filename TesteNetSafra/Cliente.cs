using System;
using System.Xml.Linq;

namespace TesteNetSafra
{
	class Cliente
	{
		public Cliente(long id, string nome = "", string documento = "")
		{
			Id =  id;
			Nome = string.IsNullOrEmpty(nome) ? Id.ToString() + " - Nome" : nome;
			Documento = string.IsNullOrEmpty(nome) ? new Random(2).Next().ToString() : documento;
		}

		public long Id { get; set; }
		public String Nome { get; set; }
		public String Documento { get; set; }
	}
}