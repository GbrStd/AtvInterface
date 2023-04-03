namespace AtvInterface._5
{
    interface IContaBancaria
    {
        void Depositar(float valor);
        void Sacar(float valor);
        float ConsultarSaldo();
    }
}
