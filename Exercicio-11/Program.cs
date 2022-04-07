using Exercicio_11;
{
    Pessoa pessoa = new Pessoa();
    pessoa.Nome = "André";
    pessoa.DataDeNascimento = new DateOnly(1996, 01, 07);
    pessoa.Altura = 1.75f;

    pessoa.imprimirDados();

    int idade = pessoa.calcularIdade();

    Console.WriteLine("Idade: " + idade);

    Console.ReadKey();
}