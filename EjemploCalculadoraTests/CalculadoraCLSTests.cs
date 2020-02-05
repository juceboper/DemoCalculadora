using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjemploCalculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCalculadora.Tests
{
    [TestClass()]
    public class CalculadoraCLSTests
    {
        [TestMethod()]
        public void SumarTest()
        {
            CalculadoraCLS cal = new CalculadoraCLS();

            double n1 = 2;
            double n2 = 3;
            double resultado = n1 + n2;

            Assert.AreEqual(5, resultado);
        }

        [TestMethod()]
        public void RestarTest()
        {
            CalculadoraCLS cal = new CalculadoraCLS();

            double n1 = 3;
            double n2 = 2;
            double resultado = n1 - n2;

            Assert.AreEqual(1, resultado);
        }

        [TestMethod()]
        public void MultiplicarTest()
        {
            CalculadoraCLS cal = new CalculadoraCLS();

            double n1 = 2;
            double n2 = 3;
            double resultado = n1 * n2;

            Assert.AreEqual(6, resultado);
        }

        [TestMethod()]
        public void DividirTest()
        {
            CalculadoraCLS cal = new CalculadoraCLS();

            double n1 = 3;
            double n2 = 2;
            double resultado = n1 / n2;

            Assert.AreEqual(1.5, resultado);
        }
    }
}