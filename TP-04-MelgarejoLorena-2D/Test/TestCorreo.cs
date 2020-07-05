using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Test
{
    [TestClass]
    public class TestCorreo
    {
        /// <summary>
        /// Verifica que la lista de Paquetes del Correo esté instanciada
        /// </summary>
        [TestMethod]
        public void TestPaqueteInstanciada()
        {
            Correo c = new Correo();
            Assert.IsNotNull(c.Paquetes);
        }


        /// <summary>
        /// verifica que no se puedan cargar dos Paquetes con el mismo Tracking ID
        /// </summary>
        [TestMethod]
        public void TestPaqueteMismoID()
        {
            Correo correo = new Correo();

            Paquete p1 = new Paquete("diccion1", "123-123-1233");
            Paquete p2 = new Paquete("diccion2", "123-123-1233");

            try
            {
                correo += p1;
                correo += p2;
            }
            catch (TrackingIdRepetidoException)
            {
                Assert.IsTrue(true);
            }
        }
    }
}
