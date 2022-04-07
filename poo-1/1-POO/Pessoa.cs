//POO é um conceito de programação que se baseia no mundo real e no mundo virtual, utilizando criação e interação
//entre objetos, atributos, métodos entre outros.
namespace poo_1
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Olhos { get; set; }
        public string CorCabelo { get; set; }
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

