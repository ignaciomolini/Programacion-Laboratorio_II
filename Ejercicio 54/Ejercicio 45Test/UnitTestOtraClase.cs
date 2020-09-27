using System;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ejercicio_45
{
    [TestClass]
    public class UnitTestOtraClase
    {
        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void TestMetodoDeInstancia()
        {
            //Arrange
            OtraClase oc = new OtraClase();
            //Act
            oc.MetodoDeInstancia();
            //Assert
        }
    }
}
