using Xunit;
using IESPeñasNegras.ProyectoEjemplo.Consola.Clases;

namespace test
{
    public class MiSegundaClaseTest
    {
        [Fact]
        public void Incrementar_Suma_Uno_Cuando_El_Numero_Entrada_Es_Superior_A_Cero()
        {
            //Arrange
            var miSegundaClase = new MiSegundaClase(1, "Mi mensaje");
            //Act
            miSegundaClase.Incrementar();

            //Assert            
            Assert.Equal(2, miSegundaClase.NumeroEntrada);
        }

        [Fact]
        public void Incrementar_Suma_Uno_Cuando_El_Numero_Entrada_Es_Igual_A_Cero()
        {
            //Arrange
            var miSegundaClase = new MiSegundaClase(0, "Mi mensaje");
            //Act
            miSegundaClase.Incrementar();

            //Assert            
            Assert.Equal(1, miSegundaClase.NumeroEntrada);
        }

        [Fact]
        public void Incrementar_NO_Suma_Uno_Cuando_El_Numero_Entrada_Es_Negativo()
        {
            //Arrange
            var miSegundaClase = new MiSegundaClase(-1, "Mi mensaje");
            //Act
            miSegundaClase.Incrementar();

            //Assert            
            Assert.Equal(-1, miSegundaClase.NumeroEntrada);
        }

        // [Fact]
        // public void FailingTest()
        // {
        //     Assert.Equal(5, Add(2, 2));
        // }

        // int Add(int x, int y)
        // {
        //     return x + y;
        // }
    }
}

