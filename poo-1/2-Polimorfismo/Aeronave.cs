//Polimorfismo representa muitas formas, como enviar uma mesma mensagem pra diferente objetos
//e fazer com que respondam de maneira certa.
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
