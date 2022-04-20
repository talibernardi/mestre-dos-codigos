//Programação Orientada a Objetos (POO) é um paradigma de programação no qual tenta aproximar a codificação das estruturas de um programa
//a objetos do mundo real,é por esse motivo que se chama orientada a "objetos" que é algo completamente genérico
//e que pode representar qualquer coisa tangivel do mundo.
namespace poo_1
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Olhos { get; set; }
        public string? CorCabelo { get; set; }
        public int Bracos { get; set; }
        public int Pernas { get; set; }

        public Pessoa(string nome, int olhos, string corCabelo, int bracos, int pernas)
        {
            Nome = nome;
            Olhos = olhos;
            CorCabelo = corCabelo;
            Bracos = bracos;
            Pernas = pernas;
        }
        public Pessoa() { }
        public override string ToString()
        {
            return $"Nome: {Nome} , Olhos: {Olhos} , Cabelo: {CorCabelo} , Braços: {Bracos} , Pernas: {Pernas} \n";
        }
    }
}

