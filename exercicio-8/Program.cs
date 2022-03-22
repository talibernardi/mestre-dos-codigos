

List<double> items = new List<double>();

Console.WriteLine("Digite um número: ");
items.Add(double.Parse(Console.ReadLine()));

Console.WriteLine("Digite um número: ");
items.Add(double.Parse(Console.ReadLine()));

Console.WriteLine("Digite um número: ");
items.Add(double.Parse(Console.ReadLine()));

Console.WriteLine("Digite um número: ");
items.Add(double.Parse(Console.ReadLine()));


var listaCrescente = items.OrderBy(x => x).ToList();
var listaDecrescente = items.OrderByDescending(x => x).ToList();

Console.WriteLine("Crescente:");
Console.WriteLine("[{0}]", string.Join(", ", listaCrescente));
Console.WriteLine("Decrescente:");
Console.WriteLine("[{0}]", string.Join(", ", listaDecrescente));