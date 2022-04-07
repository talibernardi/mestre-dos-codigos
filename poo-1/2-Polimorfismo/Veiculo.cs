
namespace poo_1._2_Polimorfismo
{
    public abstract class Veiculo
    {
        public string Tipo
        {
            get; private set;
        }

        public Veiculo(string tipoVeiculo)
        {
            Tipo = tipoVeiculo;
        }

        public virtual void Mover() { }
        public virtual void Parar() { }
    }
}
