namespace AtvInterface._3
{
    class Calculadora : ICalculadora
    {
        public float Dividir(float a, float b)
        {
            return a / b;
        }

        public float Multiplicar(float a, float b)
        {
            return a * b;
        }

        public float Somar(float a, float b)
        {
            return a + b;
        }

        public float Subtrair(float a, float b)
        {
            return a - b;
        }
    }
}
