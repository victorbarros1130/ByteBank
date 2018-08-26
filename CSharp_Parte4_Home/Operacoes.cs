using System;
using System.Linq;
using CSharp_Parte4_Home.Repositories;
using CSharp_Parte4_Home.ValueObjects;

namespace CSharp_Parte4_Home
{
	public static class Operacoes
	{
		//public static void Deposito(ContaCorrente _conta, double _valuedepositado)
		//{
		//	Console.WriteLine();
		//	Console.WriteLine("Valor depositado na conta do " + _conta.Usuario.Nome + " : R$" + _valuedepositado);
		//	_conta.Saldo += _valuedepositado;
		//	Console.WriteLine("Saldo final do " + _conta.Usuario.Nome + " : R$" + _conta.Saldo);
		//}

		public static void Deposito(DadosBancarios _dadosBancarios, double _valuedepositado)
		{
			var conta = Contas.ProcurarConta(_dadosBancarios);
			conta.DadosBancarios.Saldo += _valuedepositado;
		}

		//public static void Saque(ContaCorrente _conta,double _valuesaque)
		//{
		//	Console.WriteLine();
		//	Console.WriteLine($" Sacando R${_valuesaque} da conta do {_conta.Usuario.Nome}.");
		//	//if (_valuesaque > Saldo)
		//	//{
		//	//    Saldo -= _valuesaque;
		//	//    return;
		//	//}
		//	_conta.Saldo -= _valuesaque;
		//	Console.WriteLine("Saldo final do " + _conta.Usuario.Nome + " : R$" + _conta.Saldo);
		//}

		public static void Saque(DadosBancarios _dadosBancarios, double _valuesaque)
		{
			var conta = Contas.ProcurarConta(_dadosBancarios);
			conta.DadosBancarios.Saldo -= _valuesaque;
		}

		//public static void Transferencia(double _valueTrans, ContaCorrente _contaorigem, ContaCorrente _contadestino)
		//{
		//	//Console.WriteLine("Transferido R$" + _valueTrans + " da conta do " + Usuario.Nome + " para a " + _contadestino.Usuario.Nome + ".");
		//	Saque(_contaorigem, _valueTrans);
		//	Deposito(_contadestino, _valueTrans);
		//	Console.WriteLine();
		//	//Console.WriteLine("Saldo final de " + Usuario.Nome + ": R$" + Saldo);
		//	//Console.WriteLine("Saldo final de " + _contadestino.Usuario.Nome + ": R$" + _contadestino.Saldo);
		//}

		public static void Transferencia(DadosBancarios _dadosBancariosOrigem, DadosBancarios _dadosBancariosDestino, double _valueTrans)
		{
			Saque(_dadosBancariosOrigem, _valueTrans);
			Deposito(_dadosBancariosDestino, _valueTrans);
		}
	}
}
