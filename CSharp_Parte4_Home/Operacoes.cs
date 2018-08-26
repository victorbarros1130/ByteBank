using System;
using System.Linq;
using CSharp_Parte4_Home.Repositories;
using CSharp_Parte4_Home.ValueObjects;

namespace CSharp_Parte4_Home
{
	public static class Operacoes
	{
		public static void Deposito(DadosBancarios _dadosBancarios, double _valuedepositado)
		{
			var conta = Contas.ProcurarConta(_dadosBancarios);
			conta.DadosBancarios.Saldo += _valuedepositado;
		}

		public static void Saque(DadosBancarios _dadosBancarios, double _valuesaque)
		{
			var conta = Contas.ProcurarConta(_dadosBancarios);
			conta.DadosBancarios.Saldo -= _valuesaque;
		}

		public static void Transferencia(DadosBancarios _dadosBancariosOrigem, DadosBancarios _dadosBancariosDestino, double _valueTrans)
		{
			Saque(_dadosBancariosOrigem, _valueTrans);
			Deposito(_dadosBancariosDestino, _valueTrans);
		}
	}
}
