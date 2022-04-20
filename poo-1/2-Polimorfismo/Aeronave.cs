//Polimorfismo é o conceito que define que o mesmo método pode ser implementado de diferentes formas em objetos de diferentes classes;
namespace poo_1._2_Polimorfismo
{
    public class Aeronave : Veiculo
    {
        public Aeronave(string tipoVeiculo) : base(tipoVeiculo) { }

        public override void Mover()
        {
            Console.WriteLine("Decolando Aeronave.");
        }

        public override void Parar()
        {
            Console.WriteLine("Aterrisando Aeronave.");
        }
    }
}
