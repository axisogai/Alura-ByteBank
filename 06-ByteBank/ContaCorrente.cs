//using _05_ByteBank;

namespace _06_ByteBank
{
    public class ContaCorrente
    {


        public Cliente Titular { get; set; }
        //private Cliente _titular;

        //public Cliente Titular
        //{
        //    get
        //    {
        //        return _titular;
        //    }
        //    set
        //    {
        //        _titular = value;
        //    }
        //}

        public int Agencia { get; set; }
        public int Numero { get; set; }

        //public int agencia;
        //public int numero;
        //public double saldo = 100;
        private double _saldo = 100;

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
                    return;
                }

                _saldo = value;

            }
        }

        //public void SetSaldo(double saldo)
        ////public void DefinirSaldo(double saldo)

        //{
        //    if (saldo < 0)
        //    {
        //        return;
        //    }
        //    this.saldo = saldo;
        //}

        //public void GetSaldo()
        ////public double ObterSaldo()
        //{
        //    return saldo;
        //}

        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            this._saldo -= valor;
            return true;


            //else
            //{
            //    this.saldo -= valor;
            //    return true;
            //}
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;

        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

            //    else
            //{
            //    this.saldo -= valor;
            //    contaDestino.Depositar(valor);
            //    return true;
            //}
        }


    }
}


