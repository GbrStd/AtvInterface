namespace AtvInterface._5
{
    class ContaBancaria : IContaBancaria
    {

        public int Numero { get; set; }

        private float _Saldo;

        public float ConsultarSaldo()
        {
            return _Saldo;
        }

        public void Depositar(float valor)
        {
            this._Saldo += valor;
        }

        public void Sacar(float valor)
        {
            this._Saldo -= valor;
        }
    }
}
