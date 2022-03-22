//Diferença entre out e ref//

{
    int numero = 1;
    Ref(ref numero);
    Console.WriteLine($"Numero antes da função: {numero}");
    Out(out numero);
    Console.WriteLine($"Numero depois da função: {numero}");
}

static void Normal(int numero)
{
    numero = 1;
}

static void Ref(ref int numero)
{
    numero += 2;
}

static void Out(out int numero)
{
    numero = 3;
  
}

