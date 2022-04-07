
using Calculos;
using Xunit;

namespace CalculosTest
{
    public class CalculoUnitTest
    {
        [Fact]

        public void Somar_DoisDouble_RetornaDouble()
        {
            //Arrange
            var num1 = 2.9;
            var num2 = 3.1;
            var valorEsperado = 6;

            //Act
            var Soma = Calculo.Somar(num1, num2);

            //Assert
            Assert.Equal(valorEsperado,Soma);
        }

        [Fact]
        public void Subtrair_DoisDouble_RetornarDouble()
        {
            var num1 = 2.9;
            var num2 = 3.1;
            var valorEsperado = -0.2;

            var Subtracao = Calculo.Subtrair(num1, num2);

            Assert.Equal(valorEsperado, Subtracao, 1);
        }
            
    }
}
