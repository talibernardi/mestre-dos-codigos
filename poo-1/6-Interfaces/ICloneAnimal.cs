namespace poo_1._6_Interfaces
{
    public class Animal : ICloneable
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public Animal() { }
        public Animal(Animal p)
        {
            Nome = p.Nome;
            Idade = p.Idade;
        }
        public object Clone()
        {
            return new Animal(this);
        }
    }
}