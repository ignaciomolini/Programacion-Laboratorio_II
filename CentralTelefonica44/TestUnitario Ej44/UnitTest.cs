using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;

namespace TestUnitario_Ej44
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestListasInstanciadas()
        {
            //arrange
            Centralita c;
            //act
            c = new Centralita("Nacho Center");
            //assert
            Assert.IsNotNull(c.Llamadas);
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void TestCentralitaExceptionLocal()
        {
            //arrange
            Centralita c = new Centralita("Nacho Center");
            Llamada l1 = new Local("43425634", 23, "23455734", 54);
            Llamada l2 = new Local("43425634", 34, "23455734", 78);
            //act
            c += l1;
            c += l2;
            //assert => Arriba en en los corchetes
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void TestCentralitaExceptionProvincial()
        {
            //arrange
            Centralita c = new Centralita("Nacho Center");
            Llamada l1 = new Provincial("23459984", Provincial.Franja.Franja_2, 34, "34235671");
            Llamada l2 = new Provincial("23459984", Provincial.Franja.Franja_2, 87, "34235671");
            //act
            c += l1;
            c += l2;
            //assert => Arriba en en los corchetes
        }

        [TestMethod]
        public void TestComparacionLlamadas()
        {
            //arrange
            Llamada l1 = new Local("35667431", 23, "99436754", 54);
            Llamada l2 = new Local("35667431", 34, "99436754", 78);
            Llamada l3 = new Provincial("35667431", Provincial.Franja.Franja_2, 34, "99436754");
            Llamada l4 = new Provincial("35667431", Provincial.Franja.Franja_2, 87, "99436754");       
            bool DosLocales;
            bool DosProvinciales;
            bool UnaYUna;
            //act
            DosLocales = (l1 == l2);
            DosProvinciales = (l3 == l4);
            UnaYUna = (l1 == l3);
            //assert 
            Assert.IsTrue(DosLocales);
            Assert.IsTrue(DosProvinciales);
            Assert.IsFalse(UnaYUna);
        }
    }
}
