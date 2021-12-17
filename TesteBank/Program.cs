using System;

namespace TesteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaA = new ContaCorrente();
            ContaCorrente contaB = new ContaCorrente();

            contaA.saldo += 500;
            contaB.saldo += 1000;

            Console.WriteLine("Saldo A: " + contaA.saldo);
            Console.WriteLine("Saldo B: " + contaB.saldo);

            contaA.Depositar(250);
            bool resultadoSaqueA = contaA.Sacar(1000);

            contaB.Transferir(1100, contaA);

            Console.WriteLine("Saldo A: " + contaA.saldo);
            Console.WriteLine(resultadoSaqueA);
            Console.WriteLine("Saldo B: " + contaB.saldo);


            Console.ReadLine();


        }
    }
}
