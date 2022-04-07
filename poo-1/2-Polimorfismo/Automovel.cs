
namespace poo_1._2_Polimorfismo
{
    public class Automovel : Veiculo
    {
        public Automovel(string tipoVeiculo) : base(tipoVeiculo) { }

        public override void Mover()
        {
            Console.WriteLine("Acelerando veículo");
        }

        public override void Parar()
        {
            Console.WriteLine("Parando o veículo");
        }
    }
}
