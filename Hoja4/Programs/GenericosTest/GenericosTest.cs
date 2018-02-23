using System;
using Xunit;
using Programs;

namespace GenericosTest
{
    public class GenericosTest
    {
        [Fact]
        public void HeadTest()
        {
            int[] arreglo = {1,2,3};
            Genericos generico = new Genericos();
            int valor = generico.Head<int>(arreglo);
            Assert.AreEqual(valor,arreglo[0]);
        }

        [Fact]
        public void TailTest(){
            int[] ArregloBase = {10,20,30,40};
            Genericos generico = new Generico();
            int[] NuevoArreglo = genericos.Tail<int>(ArregloBase);
            Assert.AreEqual(ArregloBase[0],NuevoArreglo[0]);
        }

        [Fact]
        public void TestZip(){
            Genericos genericos = new Genericos();
            int[] a = { 1, 2, 3 , 4};
            int[] b = { 1, 2, 3 , 4};
            Tupla<int, int>[] arreglo = genericos.Zip<int, int>(a, b);

            for (int i = 0; i < arreglo.Length; i++)
            {
                Assert.AreEqual(a[i],arreglo[i].primero);
                Assert.AreEqual(b[i],arreglo[i].segundo);
            }
        }
    }
}
