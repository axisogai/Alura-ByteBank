using System;

namespace teste_ReferenciaObjetos
{
    class Program
    {
        static void Main(string[] args)
        {


                ContaCorrente minhaConta = new ContaCorrente();
                minhaConta.saldo = 500;

                ContaCorrente outraConta = minhaConta;
                outraConta.saldo += 1000;

                Console.WriteLine(minhaConta.saldo);
                Console.ReadLine();
          
        }
    
    }
}
