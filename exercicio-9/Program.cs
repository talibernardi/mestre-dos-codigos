using System.Linq;
//lista
List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//decrescente - crescente
var listaCrescente = numeros.OrderBy(x => x).ToList();
var listaDecrescente = numeros.OrderByDescending(x => x).ToList();

Console.WriteLine("Crescente:");
Console.WriteLine("[{0}]", string.Join(", ", listaCrescente));
Console.WriteLine("\nDecrescente:");
Console.WriteLine("[{0}]", string.Join(", ", listaDecrescente));

//pegar primeiro elemento
int First = numeros.First();
Console.WriteLine("\nPrimeiro número da lista: ");
Console.WriteLine(First);

//pegar ultimo elemento
int Last = numeros.Last();
Console.WriteLine("\nUltimo número da lista: ");
Console.WriteLine(Last);

//inserir numero no inicio da lista
var listaComNumeroNoInicio = numeros.Prepend(0);
Console.WriteLine("\nAdicionando Número no início da lista: ");
Console.WriteLine(string.Join(", ", listaComNumeroNoInicio));

//inserir numero no fim da listanumeros
var listaComNumeroNoFinal = numeros.Prepend(1);
Console.WriteLine("\nAdicionando Número no fim da lista: ");
Console.WriteLine(string.Join(", ", listaComNumeroNoFinal));

//remove primeiro numero
numeros.RemoveAt(numeros.First());
Console.WriteLine("\nRemovendo Número do início da lista: ");
Console.WriteLine(string.Join(", ", numeros));

//remove ultimo numero
numeros.RemoveAt(numeros.Last());
Console.WriteLine("\nRemovendo Número do fim da lista: ");
Console.WriteLine(string.Join(", ", numeros));

//retornando apenas numeros pares
var result = numeros.Where(x => (x % 2) == 0).ToList();
Console.Write("\nRetornando apenas números pares: ");
Console.WriteLine(string.Join(", ", result));

foreach (var _ in
//retornando apenas número informado// trocar pra posição dentro do index usando linq
from numero in numeros
where numero == 1
select new { })
{
    Console.WriteLine("\nNúmero informado: " + 1);
}

//transforme todos os numeros da lista em um array
int[] n = numeros.ToArray();
Console.WriteLine("\nArray: ");
foreach (int valor in n)
{
    Console.WriteLine($" {valor} ");
}


















