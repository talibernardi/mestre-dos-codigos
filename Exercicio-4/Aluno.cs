namespace Exercicio_4
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Nota { get; set; }

        public Aluno(int nota, string nome)
        {
            Nome = nome;    
            Nota = nota;    
        }
}
}

