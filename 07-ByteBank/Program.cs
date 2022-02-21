using System;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente(876, 86712540);
            // ContaCorrente conta =new ContaCorrente();
            //conta.Numero = 86712540;
            // conta.Agencia = 867;
            //conta.Agencia = -10;
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);



            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);
            


            ContaCorrente contaDaGabriela = new ContaCorrente(857, 86745820);


            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            Console.ReadLine();
        }
    }
}
