//O método Dispose é uma convenção do .NET Framework para que as classes disponibilizem ao programador um meio
//de liberar a memória usada sem ter que esperar o Garbage Collector fazer isso.
namespace poo_1._6_Interfaces
{
    public class IDispose : IDisposable
    {
        public string Valor = "\nObjeto Criado";

        public void Dispose()
        {
            String Valor = null;

            Console.WriteLine("A memória ocupada foi liberada!");
        }
    }
}
