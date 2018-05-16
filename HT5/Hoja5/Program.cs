using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT5

{
    public class Program
    {
        public static int ReduceInt(int [] vlr, int acc, Func<int,int,int> reduccion)
        {
            for (int i = 0; i < vlr.Length; i++)
            {
                acc = reduccion(acc, vlr[i]);
            }

            return acc;
        }

        public static A Reduce<T, A>(T[] valores, A acc, Func<A, T, A> reduccion)
        {
            for (int i = 0; i < valores.Length; i++)
            {
                acc = reduccion(acc, valores[i]);
            }

            return acc;
        }

        static void Main(string[] args)
        {

        }
    }
}
