using System;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasUnitarias
{
    [TestClass]
    public class UnitTest
    {
        /// <summary>
        /// Metodo que prueba que se instancie un turno.
        /// </summary>
        [TestMethod]
        public void AltaTurno()
        {
            //Arrange
            Turno turno;
            Paciente paciente = new Paciente(3, "Ramirez", "Jorge", 34, "Masculino", "Llavallol 342", "NoTiene");
            Especialista especialista = new Especialista(5, "Gomez", "Alberto", 45, "Masculino", "2 de Mayo 564", "Dermatologia");
            //act
            turno = new Turno(23, paciente, especialista, "Reposo");
            //Assert
            Assert.IsNotNull(turno);
        }

        /// <summary>
        /// Metodo que prueba que se serializo un turno en Xml.
        /// </summary>
        [TestMethod]
        public void SerializacionXml()
        {
            //Arrange
            bool retorno;
            Turno turno;
            Paciente paciente = new Paciente(3, "Ramirez", "Jorge", 34, "Masculino", "Llavallol 342", "NoTiene");
            Especialista especialista = new Especialista(5, "Gomez", "Alberto", 45, "Masculino", "2 de Mayo 564", "Dermatologia");
            //act
            turno = new Turno(23, paciente, especialista, "Reposo");
            retorno = Serializador<Turno>.SerializarAXml(turno, "turnoUniTest.xml");
            //Assert
            Assert.IsTrue(retorno);
        }

        /// <summary>
        /// Metodo que prueba que se deserializo un turno en Xml.
        /// </summary>
        [TestMethod]
        public void DeserializacionXml()
        {
            //Arrange
            Turno turno;  
            //act
            turno = Serializador<Turno>.DeserializarXml("turnoUniTest.xml");
            //Assert
            Assert.IsNotNull(turno);
        }

        /// <summary>
        /// Metodo que prueba que se serializo un turno en Binario.
        /// </summary>
        [TestMethod]
        public void SerializacionBinario()
        {
            //Arrange
            bool retorno;
            Turno turno;
            Paciente paciente = new Paciente(3, "Ramirez", "Jorge", 34, "Masculino", "Llavallol 342", "NoTiene");
            Especialista especialista = new Especialista(5, "Gomez", "Alberto", 45, "Masculino", "2 de Mayo 564", "Dermatologia");
            //act
            turno = new Turno(23, paciente, especialista, "Reposo");
            retorno = Serializador<Turno>.SerializarABinario(turno, "turnoUniTest.bin");
            //Assert
            Assert.IsTrue(retorno);
        }

        /// <summary>
        /// Metodo que prueba que deserializo un turno en Binario.
        /// </summary>
        [TestMethod]
        public void DeserializacionBinario()
        {
            //Arrange
            Turno turno;
            //act
            turno = Serializador<Turno>.DeserializarBinario("turnoUniTest.bin");
            //Assert
            Assert.IsNotNull(turno);
        }
    }
}
