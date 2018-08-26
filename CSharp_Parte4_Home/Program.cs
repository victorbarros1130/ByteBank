using System;
using CSharp_Parte4_Home.Repositories;
using CSharp_Parte4_Home.ValueObjects;

namespace CSharp_Parte4_Home
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao ByteBank!");

            var Victor = new Cliente("Victor");
	        var VictorDadosBancarios = new DadosBancarios()
	        {
		        Ag = 101,
		        Conta = 438
	        };
            var ContaDoVictor = new ContaCorrente(VictorDadosBancarios)
            {
                Usuario = Victor,
            };

			Console.WriteLine($"Conta do {Victor.Nome}.");

	        Operacoes.Deposito(ContaDoVictor.DadosBancarios, 981.33);
	        Operacoes.Saque(ContaDoVictor.DadosBancarios, 232.4);

            Cliente Vanessa = new Cliente("Vanessa");
            ContaCorrente ContaDaVanessa = new ContaCorrente(101, 439);
            ContaDaVanessa.Usuario = Vanessa;

	        Console.WriteLine();

			foreach (var c in Contas.BancoDeDados)
			{
				Console.WriteLine($"A Conta dx {c.Usuario.Nome} tem número {c.DadosBancarios._conta} e agência {c.DadosBancarios._ag} e Saldo {c.DadosBancarios.Saldo}.");
			}

			//Console.WriteLine("Conta da " + Vanessa.Nome + ".");

			Operacoes.Transferencia(ContaDoVictor.DadosBancarios, ContaDaVanessa.DadosBancarios, 135.76);
	        Console.WriteLine();

	        foreach (var c in Contas.BancoDeDados)
	        {
		        Console.WriteLine($"A Conta dx {c.Usuario.Nome} tem número {c.DadosBancarios._conta} e agência {c.DadosBancarios._ag} e Saldo {c.DadosBancarios.Saldo}.");
	        }


			Console.ReadLine();
        }
    }
}