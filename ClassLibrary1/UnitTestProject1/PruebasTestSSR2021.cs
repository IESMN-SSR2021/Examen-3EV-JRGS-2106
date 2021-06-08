using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Examen3EV_SSR2021;
using System;
using Examen3EV_SSR2021;

namespace PruebasTestSSR2021
{
    [TestClass]
    public class PruebasTestSSR2021
    {
        [TestMethod]
        public void PruebasNotasSSR2021()
        {
            List<int> notas = new List<int>();

            notas.Add(0);
            notas.Add(5);
            notas.Add(9);
            notas.Add(3);
            notas.Add(7);
            notas.Add(4);
            notas.Add(8);


            double mediaEsperada = 5.143;
            int SuspensosEsperados = 3;
            int AprobadosEsperados = 1;
            int NotablesEsperados = 2;
            int SobresalientesEsperados = 1;




        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NotasMenorZero()
        {

            try
            {
                double mediaEsperada = -1;
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NotasMayorDiez()
        {

            try
            {
                double mediaEsperada = 11;
                
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
