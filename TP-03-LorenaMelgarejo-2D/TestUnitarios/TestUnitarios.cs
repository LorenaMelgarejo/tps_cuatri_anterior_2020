using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Archivos;
using ClasesInstanciables;
using Excepciones;
using EntidadesAbstractas;

namespace TestUnitarios
{
    [TestClass]
    public class TestUnitarios
    {
        #region TEST UNITARIOS
        /// <summary>
        /// Metodo de test que comprueba alumno repetido y genera una excepcion
        /// </summary>
        [TestMethod]
        public void Test_AlumnoRepetido()
        {
            int ID_a2 = 2;                          

            Alumno a1 = new Alumno(1, "Marcela", "Dominguez", "31057002", Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);
            Alumno a2 = new Alumno(ID_a2, "Pablo", "Garcia", "29687769", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);
            Universidad uni = new Universidad();

            try
            {
                uni += a1;
                uni += a2;
                Assert.AreEqual(a1, a2);
            }
            catch (Exception)
            {
                throw new AlumnoRepetidoException();
            }
        }

        /// <summary>
        /// Metodo de test que valida rando de DNI dependiendo de su nacionalidad y genera una excepcion
        /// </summary>
        [TestMethod]
        public void Test_DNINacionalidadInvalida()
        {
            string DNI_FueraDeRango = "90000000";   // 90.000.000 A 99.999.999 | DNI FUERA DE RANGO EN ALUMNO a1

            Alumno a1 = new Alumno(1, "Marcela", "Dominguez", DNI_FueraDeRango, Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);
            Alumno a2 = new Alumno(2, "Pablo", "Garcia", "29687769", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);
            Universidad uni = new Universidad();

            try
            {
                uni += a1;
                uni += a2;
            }
            catch (Exception)
            {
                throw new NacionalidadInvalidaException();
            }
        }

        /// <summary>
        /// valida que el formato sea numerico para la carga del DNI
        /// </summary>
        [TestMethod]
        public void Test_DNIValorNumerico()
        {
            string DNI_FormatoNoValido = "90000000"; 

            Alumno a1 = new Alumno(1, "Marcela", "Dominguez", DNI_FormatoNoValido, Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);
            Universidad uni = new Universidad();

            try
            {
                uni += a1;
            }
            catch (Exception)
            {
                throw new DniInvalidoException();
            }
        }
        
        /// <summary>
        /// valida un tipo de clase si su valor es NULL
        /// </summary>
        [TestMethod]
        public void Test_ValorNull()
        {
            Universidad uni = new Universidad();
           

            try
            {
                Assert.IsNotNull(uni);
            }
            catch (Exception)
            {
                throw new Exception("Valor NULL");
            }
        }
        

        #endregion
    }
}
