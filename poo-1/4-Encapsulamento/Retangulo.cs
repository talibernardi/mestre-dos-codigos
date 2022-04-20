//Encapsulamento - Vem de de encapsular, que na programação orientada a objetos significa separar o programa em partes,
//as mais isoladas possíveis.
namespace poo_1._4_Encapsulamento
{
    public class Retangulo
    {
        private double comprimento;
        private double largura;


        public double GetArea()
        {
            return comprimento * largura;
        }
        public void Exibir()
        {
            Console.WriteLine("Área do Retângulo:\n");
            Console.WriteLine($"Comprimento: {comprimento}");
            Console.WriteLine($"Largura: {largura}");
            Console.WriteLine($"Area: {GetArea()}");
        }
        public void InformarValores()
        {
            Console.WriteLine("\nInforme o comprimento: ");
            comprimento = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a largura : ");
            largura = Convert.ToDouble(Console.ReadLine());
        }
    }
}
