
using System;

namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var funcionarios = new List<Funcionario>();

            funcionarios.Add(new Funcionario(1500, "Lili"));
            funcionarios.Add(new Funcionario(1700, "Jefferson"));
            funcionarios.Add(new Funcionario(4500, "Miriam"));
            funcionarios.Add(new Funcionario(3500, "Luna"));

            //Usando for
            int? maxVal = null;
            int? minVal = null;
            for (int i = 0; i < funcionarios.Count; i++)
            {
                var funcionario = funcionarios[i];
                if (maxVal is null || funcionario.Salario >= maxVal)
                {
                    maxVal = funcionario.Salario;
                }

                if (minVal is null || funcionario.Salario <= minVal)
                {
                    minVal = funcionario.Salario;
                }

                Console.WriteLine("O Funcionario " + funcionario.Nome + " tem o salário " + funcionario.Salario);
            }
            Console.WriteLine("O maior salário é de: " + maxVal);
            Console.WriteLine("O menor salário é de: " + minVal);
            Console.ReadKey();

            //Usando While//
            maxVal = null;
            minVal = null;
            int index = 0;
            while (index < funcionarios.Count)
            {
                var funcionario = funcionarios[index];
                if (maxVal is null || funcionario.Salario >= maxVal)
                {
                    maxVal = funcionario.Salario;
                }

                if (minVal is null || funcionario.Salario <= minVal)
                {
                    minVal = funcionario.Salario;
                }

                Console.WriteLine("O Funcionario " + funcionario.Nome + " tem o salário " + funcionario.Salario);
                index++;
            }
            Console.WriteLine("O maior salário é de: " + maxVal);
            Console.WriteLine("O menor salário é de: " + minVal);
            Console.ReadKey();
        }
    }
}


