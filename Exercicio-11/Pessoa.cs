
namespace Exercicio_11
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public DateOnly DataDeNascimento { get; set; }
        public float Altura { get; set; }

        public void imprimirDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.Write("Data de Nascimento: " + DataDeNascimento);
            Console.WriteLine("\nAltura: " + Altura);
        }

        public int calcularIdade()
        {
            return DateTime.Now.Year - DataDeNascimento.Year;
        }
    }


}
