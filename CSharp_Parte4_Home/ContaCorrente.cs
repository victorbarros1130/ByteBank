using System;
using CSharp_Parte4_Home.Repositories;
using CSharp_Parte4_Home.ValueObjects;

namespace CSharp_Parte4_Home
{
    public class ContaCorrente
    {
        //Aqui onde fica as informações finaceiras do cliente
        public static int TotalContasCriadas { get; private set; }
        public Cliente Usuario { get; set; }
        public DadosBancarios DadosBancarios = new DadosBancarios();

		public ContaCorrente(int _valueagencia, int _valueconta)
        {
	        DadosBancarios.Ag = _valueagencia;
	        DadosBancarios.Conta = _valueconta;
            TotalContasCriadas++;
	        DadosBancarios.Saldo = 0.01;
            Console.WriteLine();
            Console.WriteLine("Esta é a " + TotalContasCriadas + "º conta criada!");
            Console.WriteLine("Agência " + DadosBancarios.Ag + " | Conta " + DadosBancarios.Conta);
            Console.WriteLine("Saldo inicial: R$" + DadosBancarios.Saldo + " | Todos nossos clientes ao entrar iniciam sua conta com 1 centavo!");
			Contas.AdicionarNovaConta(this);
        }

	    public ContaCorrente(DadosBancarios _dadosBancarios)
	    {
		    DadosBancarios = _dadosBancarios;
		    Contas.AdicionarNovaConta(this);
		}
	}
}