using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CShp_Calculos.Test
{
    public class CalculoUnitTest
    {
        // metodo para testes sem parametros usa-se [Fact] => [Theory] para testes com parametros
        [Fact]
        public void Somar_DoisDouble_RetornaDouble() // nome do metodo teste deve ser o maximo sugestivo ao mesmo
        {
            // Arrange - É aqui que você normalmente prepara tudo para o teste, em outras palavras, prepara a cena para testar
            var num1 = 2.9;
            var num2 = 3.1;
            var valorEsperado = 6;

            // Act  
            var soma = Calculo.Somar(num1, num2);
            //Assert  
            Assert.Equal(valorEsperado, soma);
        }

        [Theory]

        [InlineData(1, 2, 3)]
        [InlineData(-4, -6, -10)]
        [InlineData(-2, 2, 0)]
        [InlineData(int.MinValue, -1, int.MaxValue)]
        public void Somar_DoisNumerosRelativos_RetornaNumeroRelativo(int num1, int num2, int valorEsperado)
        {
            //Act
            var resultado = Calculo.Somar(num1, num2);
            //Assert
            Assert.Equal(valorEsperado, resultado);
        }

        [Fact]
        public void Subtrair_DoisDouble_RetornaDouble()
        {
            // Arrange  
            var num1 = 2.9;
            var num2 = 3.1;
            var valorEsperado = -0.2;
            // Act  
            var subtracao = Calculo.Subtrair(num1, num2);
            //Assert  
            Assert.Equal(valorEsperado, subtracao, 1);
        }
        [Fact]
        public void Multiplicar_DoisDouble_RetornaDouble()
        {
            // Arrange  
            var num1 = 2.9;
            var num2 = 3.1;
            var valorEsperado = 8.99;
            // Act  
            var mult = Calculo.Multiplicar(num1, num2);
            //Assert  
            Assert.Equal(valorEsperado, mult, 2);
        }
        [Fact]
        public void Dividir_DoisDouble_RetornaDouble()
        {
            // Arrange  
            var num1 = 2.9;
            var num2 = 3.1;
            var valorEsperado = 0.94; //Rounded value  
            // Act  
            var div = Calculo.Dividir(num1, num2);
            //Assert  
            Assert.Equal(valorEsperado, div, 2);
        }
    }
}
