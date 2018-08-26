using System;

namespace CSharp_Parte4_Home
{
    public class ContaCorrente
    {
        //Aqui onde fica as informações finaceiras do cliente
        public static int TotalContasCriadas { get; private set; }
        public Cliente Usuario { get; set; }
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
                    Console.WriteLine();
                    //                    Console.WriteLine("Opss! O saldo não pode ficar negativo. =)");
                    Console.WriteLine("Saldo do " + Usuario.Nome + " é : R$" + _saldo);
                    throw new ArgumentException("Opss!O saldo não pode ficar negativo. =)");
                }
                _saldo = value;
            }
        }

        public ContaCorrente(int _valueagencia, int _valueconta)
        {
            Ag = _valueagencia;
            Conta = _valueconta;
            TotalContasCriadas++;
            Saldo = 0.01;
            Console.WriteLine();
            Console.WriteLine("Esta é a " + TotalContasCriadas + "º conta criada!");
            Console.WriteLine("Agência " + Ag + " | Conta " + Conta);
            Console.WriteLine("Saldo inicial: R$" + Saldo + " | Todos nossos clientes ao entrar iniciam sua conta com 1 centavo!");
        }
        public void Deposito(double _valuedepositado)
        {
            Console.WriteLine();
            Console.WriteLine("Valor depositado na conta do " + Usuario.Nome + " : R$" + _valuedepositado);
            Saldo += _valuedepositado;
            Console.WriteLine("Saldo final do " + Usuario.Nome + " : R$" + Saldo);
        }

        public void Saque(double _valuesaque)
        {
            Console.WriteLine();
            Console.WriteLine($" Sacando R${_valuesaque} da conta do {Usuario.Nome}.");
            //if (_valuesaque > Saldo)
            //{
            //    Saldo -= _valuesaque;
            //    return;
            //}
            Saldo -= _valuesaque;
            Console.WriteLine("Saldo final do " + Usuario.Nome + " : R$" + Saldo);
        }

        public void Transferencia(double _valueTrans, ContaCorrente _contadestino)
        {
            Console.WriteLine("Transferido R$" + _valueTrans + " da conta do " + Usuario.Nome + " para a " + _contadestino.Usuario.Nome + ".");
            Saque(_valueTrans);
            _contadestino.Deposito(_valueTrans);
            Console.WriteLine();
            //Console.WriteLine("Saldo final de " + Usuario.Nome + ": R$" + Saldo);
            //Console.WriteLine("Saldo final de " + _contadestino.Usuario.Nome + ": R$" + _contadestino.Saldo);
        }


    }
}