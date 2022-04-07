
namespace POO_12
{
    public class ContaCorrente : ContaBancaria, IImprimivel
    {
        public ContaCorrente(int numeroDaConta, double saldo, double taxaDeOperacao) : base(numeroDaConta, saldo)
        {
            TaxaDeOperacao = taxaDeOperacao;
        }

        public double TaxaDeOperacao { get; set; }

        public override void Depositar(double valor) => Saldo += valor - TaxaDeOperacao;
 
        public override void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                throw new InvalidOperationException("Valor do saque é maior que o saldo disponível na conta");
            }

            Saldo -= (valor + TaxaDeOperacao);
        }

        public string mostrarDados()
        {
            return $"Conta Corrente. \nNúmero da conta: {NumeroDaConta} \nSaldo: {Saldo} R$ \nTaxa de operação: {TaxaDeOperacao}";


        }
    }
}


