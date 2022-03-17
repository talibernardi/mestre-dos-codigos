using Exercicio_4;

var alunos = new List<Aluno>();

alunos.Add(new Aluno(8, "Luna"));
alunos.Add(new Aluno(8, "Luiz"));
alunos.Add(new Aluno(9, "Maria"));
alunos.Add(new Aluno(7, "João"));
alunos.Add(new Aluno(10, "Lili"));
alunos.Add(new Aluno(10, "André"));
alunos.Add(new Aluno(9, "Tati"));
alunos.Add(new Aluno(5, "Yuna"));
alunos.Add(new Aluno(6, "Nala"));



foreach(var aluno in alunos)
{
    if (aluno.Nota > 7)
    {
        Console.WriteLine(aluno.Nome + " " + aluno.Nota);
    }
}
