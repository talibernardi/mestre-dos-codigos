//IComparable define um método genérico de comparação 
namespace poo_1._6_Interfaces
{
    public class Funcionario : IComparable<Funcionario>
    {
        public string Nome { get; private set; }
        public double Salario { get; private set; }

        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public int CompareTo(Funcionario? funcionario)
        {
            if (funcionario is null) return -1;
            //salario igual = ordenaçao alfabetica
            if (Salario == funcionario.Salario)
            {
                return Nome.CompareTo(funcionario.Nome);
            }
            //maior salario para menor 
            return funcionario.Salario.CompareTo(this.Salario);
        }

        public override string ToString()
        {
            return this.Salario.ToString() + this.Nome;
        }

        public override bool Equals(object? obj)
        {
            if (obj is null)
                return false;

            if (!(obj is Funcionario))
                throw new NotImplementedException();

            var funcionario = (Funcionario)obj;

            return Nome == funcionario.Nome && Salario == funcionario.Salario;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(Funcionario left, Funcionario right)
        {
            if (ReferenceEquals(left, null))
            {
                return ReferenceEquals(right, null);
            }

            return left.Equals(right);
        }

        public static bool operator !=(Funcionario left, Funcionario right)
        {
            return !(left == right);
        }

        public static bool operator <(Funcionario left, Funcionario right)
        {
            return ReferenceEquals(left, null) ? !ReferenceEquals(right, null) : left.CompareTo(right) < 0;
        }

        public static bool operator <=(Funcionario left, Funcionario right)
        {
            return ReferenceEquals(left, null) || left.CompareTo(right) <= 0;
        }

        public static bool operator >(Funcionario left, Funcionario right)
        {
            return !ReferenceEquals(left, null) && left.CompareTo(right) > 0;
        }

        public static bool operator >=(Funcionario left, Funcionario right)
        {
            return ReferenceEquals(left, null) ? ReferenceEquals(right, null) : left.CompareTo(right) >= 0;
        }
    }
}
