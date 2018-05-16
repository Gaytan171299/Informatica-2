using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hoja5;

namespace ReduceTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestReduceN()
        {
            int[] valores = new int[] { 2, 4, 5, 9 };
            Assert.AreEqual(Program.ReduceInt(valores, 0, (acumulador, valor) => acumulador + valor), 20);
        }

        [TestMethod]
        public void TestReduceG()
        {
            string[] valores = new string[] { "Que", "onda", "vos" };
            Assert.AreEqual(Program.Reduce<string, int>(valores, 0, (acumulador, valor) => acumulador + valor.Length), 13);
        }
    }
}
