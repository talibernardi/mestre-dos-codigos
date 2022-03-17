namespace Exercicio_2
{
    public class Funcionario
    {
       public string Nome { get; set; }
        public int Salario { get; set; }

        public Funcionario(int salario, string nome)
        {
            Salario = salario;
            Nome = nome;
        }
    }
}
