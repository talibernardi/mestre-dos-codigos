    using Exercicio_2;

    List<Funcionario> listaFuncionario = new List<Funcionario>();

    while (true)
    {
        const string frase = "Digite Nome para adicionar; Digite Parar para retornar resultados.";
        Console.WriteLine(frase);
        string? nome;
        nome = Console.ReadLine();
        while (nome?.Length == 0) 
        {
          Console.WriteLine(frase);
          nome = Console.ReadLine();
        }
        if (nome == "Parar")
            break;

        double salario;
        Console.WriteLine("Digite o salário:");
        while ((!double.TryParse(Console.ReadLine(), out salario)) || (salario < 0))
            Console.WriteLine("Valor inválido. Digite o salário:");
        if (nome != null)
        {
            listaFuncionario.Add(new Funcionario(nome, salario));
        } 
    }

    if (listaFuncionario.Count == 0)
    {
        Console.WriteLine("Nenhum funcionário informado");
        return;
    }

     double maxVal = 0;
     double minVal = listaFuncionario.First().Salario;
    for (int i = 0; i < listaFuncionario.Count; i++)
    {
        var funcionario = listaFuncionario[i];
        if (funcionario.Salario >= maxVal)
        {
            maxVal = funcionario.Salario;
        }

        if (funcionario.Salario <= minVal)
        {
            minVal = (funcionario.Salario);
        }

        Console.WriteLine("O Funcionario " + funcionario.Nome + " tem o salário " + funcionario.Salario);
    }
        Console.WriteLine("O maior salário é de: " + maxVal);
        Console.WriteLine("O menor salário é de: " + minVal);
        Console.ReadKey();



