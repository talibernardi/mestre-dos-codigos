
namespace POO_12
{
    public class ContaEspecial : ContaBancaria, IImprimivel
    {
        public ContaEspecial(int numeroDaConta, double saldo, double limite) : base(numeroDaConta, saldo)
        {
            Limite = limite;
        }

        public double Limite { get; set; }

        public override void Depositar(double valor)
        {
            Saldo += valor;
        }

        public override void Sacar(double valor)
        {
            if (valor > Saldo + Limite)
            {
                throw new InvalidOperationException("Limite para saque atingido");
            }
            Saldo -= valor;
        }

        public string mostrarDados()
        {
            return $"Tipo:Conta Especial \nNúmero da conta: {NumeroDaConta} \nSaldo:R$ {Saldo}  \nLimite: {Limite}";
        }
    }
}
