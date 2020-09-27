using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Ejercicio_45
{
    [TestClass]
    public class UnitTestMiClase
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestConstructorSinParametros()
        {
            //Arrange
            new MiClase();
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void TestConstructorConParametros()
        {
            //Arrange
            new MiClase("");
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestMetodoEstaticoLanzar()
        {
            //Arrange
            MiClase.Lanzar();
            //Assert
        }
    }
}
