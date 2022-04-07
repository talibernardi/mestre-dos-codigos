
public class Animal : ICloneable
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public Animal() { }
    public Animal(Animal p)
    {
        this.Nome = p.Nome;
        this.Idade = p.Idade;
    }
    public object Clone()
    {
        return new Animal(this);
    }
}