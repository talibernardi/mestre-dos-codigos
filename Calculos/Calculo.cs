//Testes Unitarios XUnit

namespace Calculos
{
    public static class Calculo
    {
        public static double Somar(double numero1, double numero2) => numero1 + numero2;
        public static double Subtrair(double numero1, double numero2) => numero1 - numero2;
        public static double Multiplicar(double numero1, double numero2) => numero1 * numero2;
        public static double Dividir(double numero1, double numero2) => numero1 / numero2;
        public static bool IsNumeroPar(int numero) => numero % 2 == 0;
    }
}
