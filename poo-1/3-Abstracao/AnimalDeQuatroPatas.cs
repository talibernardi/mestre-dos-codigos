//Abstração - funciona abstraindo conceitos gerais de classes especificas que podem ser derivadas.
namespace poo_1._3_Abstracao

{
    abstract class AnimalDeQuatroPatas
    {
        public abstract string Describe();

    }

    class Dog : AnimalDeQuatroPatas
    {
        public override string Describe()
        {
            return "\nEsse animal de quatro patas é um cachorro!";

        }
    }
}

