List<int> numeros = new List<int>();

Console.WriteLine("Digite um número: ");
numeros.Add(int.Parse(Console.ReadLine()));

Console.WriteLine("Digite um número: ");
numeros.Add(int.Parse(Console.ReadLine()));

Console.WriteLine("Digite um número: ");
numeros.Add(int.Parse(Console.ReadLine()));

Console.WriteLine("Digite um número: ");
numeros.Add(int.Parse(Console.ReadLine()));

int soma = 0;

foreach (var numero in numeros) {
    if(numero % 2 == 0)
    {
        soma += numero;
    }
}
Console.WriteLine(soma);