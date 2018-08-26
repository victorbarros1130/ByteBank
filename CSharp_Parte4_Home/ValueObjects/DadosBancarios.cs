using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Parte4_Home.ValueObjects
{
	public class DadosBancarios
	{
		public int _ag { get; private set; }
		public int Ag
		{
			get
			{
				return _ag;
			}
			set
			{
				if (value <= 0)
				{
					Console.WriteLine();
					Console.WriteLine("Agencia não pode ser negativo. =)");
					return;
				}
				_ag = value;
			}
		}

		public int _conta { get; private set; }
		public int Conta
		{
			get
			{
				return _conta;
			}
			set
			{
				if (value <= 0)
				{
					Console.WriteLine();
					Console.WriteLine("Conta não pode ser negativo. =)");
					return;
				}
				_conta = value;
			}
		}

		public double _saldo { get; private set; }
		public double Saldo
		{
			get
			{
				return _saldo;
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentException("Opss!O saldo não pode ficar negativo. =)");
				}
				_saldo = value;
			}
		}

		public DadosBancarios()
		{
			Saldo = 0.01;
		}
	}
}
