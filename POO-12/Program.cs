using POO_12;

var contaCorrente = new ContaCorrente(227,500,10);

Console.WriteLine(contaCorrente.mostrarDados());
contaCorrente.Depositar(300);
Console.WriteLine("Depósito de: R$300");
Console.WriteLine(contaCorrente.Saldo);
Console.WriteLine("\n" + contaCorrente.mostrarDados());
contaCorrente.Sacar(300);
Console.WriteLine("Saque de R$300");
Console.WriteLine(contaCorrente.Saldo + "\n");

var contaEspecial = new ContaEspecial(557, 500, 700);

Console.WriteLine(contaEspecial.mostrarDados());
contaEspecial.Depositar(300);
Console.WriteLine("Depósito de: R$300");
Console.WriteLine(contaEspecial.Saldo);
Console.WriteLine("\n" + contaEspecial.mostrarDados());
contaEspecial.Sacar(300);
Console.WriteLine("Saque de R$300");
Console.WriteLine(contaEspecial.Saldo);








