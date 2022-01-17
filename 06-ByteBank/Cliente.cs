using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    public class Cliente
    {
        private string _cpf;

        public string Nome { get; set; }
        public string CPF 
        {
            get 
            { 
                return _cpf;
            }
            set 
            {   //Escrevo minha lógica de validaçãod e CPF
                _cpf = value;
            }
        }
        public string Profissao { get; set; }

        //public string nome;
        //public string cpf;
        //public string profissao;
    }
}
