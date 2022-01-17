using System;

namespace TesteReferencias
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaCamila = new ContaCorrente();
            contaDaCamila.Titular = new Cliente();

            contaDaCamila.Titular.Nome = "Camila";



        }
    }
}
