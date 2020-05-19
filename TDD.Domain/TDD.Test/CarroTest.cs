using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD.Domain;

namespace TDD.Test
{
    [TestClass]
    public class CarroTest
    {
        [TestMethod]
        public void DevePossuirMotor()
        {
            Carro carro = new Carro();
            Assert.IsNotNull(carro.Motor);
        }

        [TestMethod]
        public void DevePossuirQuatroRodas()
        {
            Carro carro = new Carro();
            List<Roda> rodas = carro.Rodas;

            Assert.AreEqual(4, rodas.Count);
        }
        [TestMethod]
        public void DevePosuuirDuasPortas()
        {
            Carro carro = new Carro();
            List<Porta> portas = carro.Portas;

            Assert.AreEqual(2, portas.Count);

            Console.WriteLine();
        }
    }
}
