using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteNetSafra
{
	class Program
	{
		static void Main(string[] args)
		{
            Ex02b();

			System.Console.ReadLine();
		}

		private static void Ex02()
		{
			List<Cliente> lstCliente = new List<Cliente>{ new Cliente(1), new Cliente(2)};

			List<Operacao> lstOperacao = new List<Operacao>();
			lstCliente.ForEach(cliente =>
			{
				lstOperacao.Add(new Operacao(cliente.Id * 10, cliente));
				lstOperacao.Add(new Operacao(cliente.Id * 11, cliente));
				lstOperacao.Add(new Operacao(cliente.Id * 12, cliente));
			});

			var lstConsulta = (
				from cli in lstCliente
				join op in lstOperacao
				on cli.Id equals op.IdCliente
				select new {
					OperacaoId = op.Id,
					OperacaoDataMovimento = op.DataMovimento,
					OperacaoQuantidade = op. Quantidade,
					OperacaoValorPu = op.ValorPu,
					OperacaoValorTotal = op.ValorTotal,

					ClienteId = cli.Id,
					ClienteNome = cli.Nome,
					ClienteDocumento = cli.Documento
				}).ToList();

			System.Console.WriteLine();
		}

        private static void Ex02b()
        {
            List<Cliente> lstCliente = new List<Cliente> { new Cliente(1), new Cliente(2) };

            List<Operacao> lstOperacao = new List<Operacao>();
            lstCliente.ForEach(cliente =>
            {
                lstOperacao.Add(new Operacao(cliente.Id * 10, cliente));
                lstOperacao.Add(new Operacao(cliente.Id * 11, cliente));
                lstOperacao.Add(new Operacao(cliente.Id * 12, cliente));
            });

            var lstConsulta = (
                from cli in lstCliente
                from op in lstOperacao
                where cli.Id == op.IdCliente
                select new
                {
                    OperacaoId = op.Id,
                    OperacaoDataMovimento = op.DataMovimento,
                    OperacaoQuantidade = op.Quantidade,
                    OperacaoValorPu = op.ValorPu,
                    OperacaoValorTotal = op.ValorTotal,

                    ClienteId = cli.Id,
                    ClienteNome = cli.Nome,
                    ClienteDocumento = cli.Documento
                }).ToList();

            System.Console.WriteLine();
        }

		private static void Ex03()
		{
			Singleton singleTonObj01 = Singleton.CreateObject();

			Console.WriteLine("SingleTon criado. ID = {0}", singleTonObj01.Id);

			//try to create second object
			Singleton singleTonObj02 = Singleton.CreateObject();

			Console.WriteLine("SingleTon criado. ID = {0}", singleTonObj02.Id);

			Console.WriteLine(singleTonObj01 == singleTonObj02
				? "SingleTon pode conter apenas uma instanciação por aplicação, o objeto foi reiniciado."
				: "Objeto criado com sucesso.");


			System.Reflection.MemberInfo info = typeof(Singleton);
			info.GetCustomAttributes(true).ToList().ForEach(item =>
			{
				Console.WriteLine(item.ToString());

			});

			Console.ReadLine();
		}

		private static void Ex04()
		{
			List<Cliente> lstClientes = new List<Cliente>
			{
				new Cliente(1, "John"),
				new Cliente(2, "Paul"),
				new Cliente(3, "Ringo"),
				new Cliente(4, "George"),
				new Cliente(5, "John"),
				new Cliente(6, "John"),
				new Cliente(7, "Paul"),
				new Cliente(8, "Ringo"),
				new Cliente(9, "George"),
				new Cliente(10, "George")
			};

			var lstClientesFiltrados01 = lstClientes
										.GroupBy(item => item.Nome)
										.Select(subitem => subitem.First().Nome)
										.ToList();

			lstClientesFiltrados01.ForEach(item => Console.WriteLine(item));

			Console.WriteLine();
			var lstClientesFiltrados02 = from cli in lstClientes
										group cli by new {cli.Nome}
										into newGroup
										select newGroup.FirstOrDefault();

			lstClientesFiltrados02.ToList().ForEach(item => Console.WriteLine(item.Nome));

			Console.WriteLine();
            var lstClientesFiltrados03 = lstClientes.Select(item => item.Nome).Distinct();
			lstClientesFiltrados03.ToList().ForEach(item => Console.WriteLine(item));

		}
	}
}

