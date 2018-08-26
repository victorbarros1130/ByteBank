using System;

namespace CSharp_Parte4_Home
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao ByteBank!");

            var Victor = new Cliente("Victor");
            var ContaDoVictor = new ContaCorrente(101, 438)
            {
                Usuario = Victor,
            };
            Console.WriteLine($"Conta do {Victor.Nome}.");

            ContaDoVictor.Deposito(981.33);
            ContaDoVictor.Saque(232.4);

            Cliente Vanessa = new Cliente("Vanessa");
            ContaCorrente ContaDaVanessa = new ContaCorrente(101, 439);
            ContaDaVanessa.Usuario = Vanessa;
            Console.WriteLine("Conta da " + Vanessa.Nome + ".");

            ContaDoVictor.Transferencia(135.76, ContaDaVanessa);

            Console.ReadLine();
        }
    }
}