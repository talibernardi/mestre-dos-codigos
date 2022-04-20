//O método Dispose é uma convenção do .NET Framework para que as classes disponibilizem ao programador um meio
//de liberar a memória usada sem ter que esperar o Garbage Collector fazer isso.
using System.Text;

namespace poo_1._6_Interfaces
{
    public class Log : IDisposable
    {
        private readonly FileStream _fileStream;
        internal static Log log;

        public Log(string nomeArquivo)
        {
            _fileStream = new FileStream(nomeArquivo, FileMode.OpenOrCreate, FileAccess.Write);
        }
        public void GravarLog(string log)
        {
            byte[] dados = Encoding.ASCII.GetBytes(log);
            _fileStream.Write(dados, 0, dados.Length);
        }
        public void Dispose()
        {
            _fileStream?.Close();
            _fileStream?.Dispose();
        }

        public static class ExemploIDisposable
        {
            public static void Executar()
            {
                Console.WriteLine("\n*IDisposable*");
                Console.WriteLine("Gravando Logs, por favor aguarde!");
                using (Log log = new Log($"ArquivoLog_{Guid.NewGuid()}.txt"))
                {
                    log.GravarLog("Primeiro Log");
                    log.GravarLog("Segundo Log");
                }
            }
        }
    }
}