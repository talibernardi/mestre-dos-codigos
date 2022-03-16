using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        private static object e;

        static void Main(string[] args)
        {
            int n1, n2, n3, resultado;

            Console.Write("Informe o 1 numero - >");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o 2 numero ->");
            n2 = int.Parse(Console.ReadLine());

            Somar(n1, n2);
            Subtrair(n1, n2);
            Dividir(n1, n2);
            Multiplicar(n1, n2);

            Console.Write("Informe um número qualquer.");
            n3 = int.Parse(Console.ReadLine());

            ImparPar(n3);

            Console.ReadKey();
        }

        private static void Somar(int numeroUm, int numeroDois)
        {
            var resultado = numeroUm + numeroDois;
            Console.WriteLine("O resultado da soma é: " + resultado);
        }

        private static void Subtrair(int numeroUm, int numeroDois)
        {
            var resultado = numeroUm - numeroDois;
            Console.WriteLine("O resultado da subtração é: " + resultado);
        }

        private static void Dividir(int numeroUm, int numeroDois)
        {
            try
            {
                var resultado = numeroUm / numeroDois;
                Console.WriteLine("O resultado da divisão é: " + resultado);
            }
            catch (Exception)
            {
                Console.WriteLine("Número não é divisivel por zero");
            }
        }

        private static void Multiplicar(int numeroUm, int numeroDois)
        {
            var resultado = numeroUm * numeroDois;
            Console.WriteLine("O resultado da multiplicação é: " + resultado);
        }

        private static void ImparPar(int num)
        {
            string msg = num % 2 == 0 ? " é par" : " é ímpar";
            Console.WriteLine("O número inserido: " + num + msg);

        }
    }
}
