//IComparable define um método genérico de comparação 
namespace poo_1._6_Interfaces
{
    public class Funcionario : IComparable<Funcionario>
    {
        public string Nome { get; set; }
        public string Salario { get; set; }

        public int CompareTo(Funcionario funcionario)
        {
            //salario igual = ordenaçao alfabetica
            if (this.Salario == funcionario.Salario)
            {
                return this.Nome.CompareTo(funcionario.Nome);
            }

            //maior salario para menor 
            return funcionario.Salario.CompareTo(this.Salario);
        }

        public override string ToString()
        {
            return this.Salario.ToString() + this.Nome;
        }
    }
}
