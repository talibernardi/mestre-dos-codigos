namespace NUCalculos
{
    public class Calculadora
    {
        public int Soma(int numero1, int numero2) => numero1 + numero2;
        public int Subtracao(int numero1, int numero2) => numero1 - numero2;
        public int Multiplicacao(int numero1, int numero2) => numero1 * numero2;
        public int Divisao(int dividendo, int divisor) => dividendo / divisor;
        public (int quociente, int resto) RestoDivisao(int dividendo, int divisor) => (dividendo / divisor, dividendo % divisor);
    }
}