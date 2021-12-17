using System;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Gabriela";
            //conta.saldo = 500;


            Console.WriteLine(conta.titular);
            Console.WriteLine(conta.saldo);
            Console.WriteLine(conta.agencia);
            Console.WriteLine(conta.numero);


            Console.ReadLine();
        }
    }
}
