using NUCalculos;
using NUnit.Framework;

namespace Calculos.Test
{
    public class Tests
    {
        [TestFixture]
        public class CalculadoraTest
        {
            [Test]
            public void Soma_DeveRetornarOValorCorreto()
            {
                Calculadora c = new Calculadora();
                var resultado = c.Soma(10, 20);
                //Verifica se o resultado é igual a 30
                Assert.AreEqual(30, resultado);
            }
        }
    }
}