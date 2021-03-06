﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_Parte4_Home.ValueObjects;

namespace CSharp_Parte4_Home.Repositories
{
	public static class Contas
	{
		public static List<ContaCorrente> BancoDeDados = new List<ContaCorrente>();


		public static void AdicionarNovaConta(ContaCorrente novaconta)
		{
			BancoDeDados.Add(novaconta);
		}

		public static ContaCorrente ProcurarConta(DadosBancarios _dadosBancarios)
		{
			return BancoDeDados.FirstOrDefault(x => x.DadosBancarios.Conta == _dadosBancarios._conta && x.DadosBancarios.Ag == _dadosBancarios._ag);
		}
	}
}
