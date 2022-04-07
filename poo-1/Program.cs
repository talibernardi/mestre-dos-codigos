
using Exercicio_11;
using poo_1;
using poo_1._2_Polimorfismo;
using poo_1._3_Abstracao;
using poo_1._4_Encapsulamento;
using poo_1._5_POO;
using poo_1._6_Interfaces;

//POO//
poo_1.Pessoa pessoa = new poo_1.Pessoa();
pessoa.Nome = "Talita Bernardino";
pessoa.Bracos = 2;
pessoa.Pernas = 2;
pessoa.Olhos = 2;
pessoa.CorCabelo = "Preto";

Console.WriteLine(pessoa.ToString());

//Polimorfismo//
Veiculo[] veiculo = new Veiculo[2];

veiculo[0] = new Automovel("Ferrari");
veiculo[1] = new Aeronave("Tucano");

MovimentarVeiculo(veiculo[0]);
MovimentarVeiculo(veiculo[1]);
Console.ReadKey();

static void MovimentarVeiculo(Veiculo veiculo)
{
    Console.WriteLine(veiculo.Tipo);
    veiculo.Mover();
}

//Abstração//
Dog dog = new Dog();
Console.WriteLine(dog.Describe());
Console.ReadKey();


//Encapsulamento//
var retangulo = new Retangulo();
retangulo.InformarValores();
retangulo.Exibir();
Console.ReadLine();

//Quando usar classe abstrata ou Interface
Carro carro = new Carro();
carro.darPartida();

//IDsposable
IDispose idispose = new IDispose();
Console.WriteLine(idispose.Valor);
idispose.Dispose();
Console.ReadKey();

//Icomparable
List<Funcionario> lista = new List<Funcionario>();
lista.Add(new Funcionario() { Nome = "Andre", Salario = "\n8000" });
lista.Add(new Funcionario() { Nome = "Lili", Salario = "\n10000" });
lista.Add(new Funcionario() { Nome = "Yuna", Salario = "\n10000" });
lista.Add(new Funcionario() { Nome = "Sailor", Salario = "\n10000" });
lista.Add(new Funcionario() { Nome = "Luna", Salario = "\n9000" });
lista.Sort();

foreach (var funcionario in lista)
{
    Console.WriteLine(funcionario);
}
Console.ReadLine();

//ICloneable
Animal animal = new Animal { Nome = "Lili", Idade = 2 };
Animal animal_clone = (Animal)animal.Clone();

Console.WriteLine("Animal");
Console.WriteLine(animal.Nome + " " + animal.Idade);

//Valores clone
Console.WriteLine("Animal Clone");
Console.WriteLine(animal_clone.Nome + " " + animal_clone.Idade);
Console.ReadLine();

//IEnumerable - é uma interface que obtém um enumerador que implementa a interface IEnumerator, que permite iterarmos pela coleção.
//NÃO existe herança múltipla de classes em C#
var Numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6 };
foreach (int element in Numbers)
{
    Console.Write($"{element} ");
}

