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
numeros.Insert(0, 0);
Console.WriteLine("\nAdicionando Número no início da lista: ");
Console.WriteLine(string.Join(", ", numeros));

//inserir numero no fim da lista
numeros.Insert(11, 11);
Console.WriteLine("\nAdicionando Número no fim da lista: ");
Console.WriteLine(string.Join(", ", numeros));

//remove primeiro numero
numeros.RemoveAt(0);
Console.WriteLine("\nRemovendo Número do início da lista: ");
Console.WriteLine(string.Join(", ", numeros));

//remove ultimo numero
numeros.RemoveAt(10);
Console.WriteLine("\nRemovendo Número do fim da lista: ");
Console.WriteLine(string.Join(", ", numeros));

//retornando apenas numeros pares
var result = numeros.Where(x => (x % 2) == 0).ToList();
Console.Write("\nRetornando apenas números pares: ");
Console.WriteLine(string.Join(", ", result));

//retornando apenas número informado
foreach (var numero in numeros)
{
    if (numero == 1)
    {
        Console.WriteLine("\nNúmero informado: " + 1);
    }
}

//transforme todos os numeros da lista em um array
int[] n = numeros.ToArray();
Console.WriteLine("\nArray: ");
foreach (int valor in n)
{
    Console.WriteLine($" {valor} ");
}


















