using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiplesMayores;

namespace MultiplesMayores.Pruebas
{
    [TestClass()]
    public class ProgramPruebas
    {
        [TestMethod()]
        public void IdentificaUnicoMayor()
        {
            //Arrange - Arreglar/Organizar/Preparar
            int[] numerosPrueba = { 13, 19, 0, -1, -45 };
            int numeroMayor, cantidadVeces;

            //Act - Actuar/Ejecutar
            Program.EncuentraMayores(numerosPrueba, out numeroMayor, out cantidadVeces);

            //Assert - Validar/Comprobar/Verificar
            int cantidadEsperada = 1;
            Assert.AreEqual(cantidadEsperada, cantidadVeces);
        }

        [TestMethod()]
        public void PruebaValorMayor()
        {
            //Arrange - Arreglar/Organizar/Preparar
            int[] numerosPrueba = { 10, 20, 30, -80, 80 };
            int numeroMayor, cantidadVeces;

            //Act - Actuar/Ejecutar
            Program.EncuentraMayores(numerosPrueba, out numeroMayor, out cantidadVeces);

            //Assert - Validar/Comprobar/Verificar
            int valorEsperado = 80;
            Assert.AreEqual(valorEsperado, numeroMayor);
        }
    }
}