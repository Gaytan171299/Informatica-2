namespace Genericos
{
    public class Genericos
    {
        public Genericos() { }


        //retorno del primer elemento de la lista
        public T Head<T>(T[] lista)
        {
            return lista[0];
        }

        //retorno del mismo arreglo a excepcion del primer elemto
        public T[] Tail<T>(T[] lista)
        {
            T[] nuevaLista = new T[lista.Length - 1];
            int comodin = 0;
            for (int i = 1; i < lista.Length; i++)
            {
                nuevaLista[comodin] = lista[i];
                comodin += 1;
            }
            return nuevaLista;
        }

        //retorno de un arreglo de tuplas
        public Tupla<T1, T2>[] Zip<T1, T2>(T1[] listaA, T2[] listaB)
        {
            Tupla<T1, T2>[] arreglo = new Tupla<T1, T2>[Longitud<T1, T2>(listaA, listaB)];

            //agregando valores al arreglo
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = new Tupla<T1, T2>(listaA[i], listaB[i]);
            }
            return arreglo;
        }

        //calculo de la longitud del arreglo de las tuplas
        private int Longitud<T1, T2>(T1[] valorA, T2[] valorB)
        {
            int longitud = 0;
            if (valorA.Length == valorB.Length)
            {
                longitud = valorA.Length;
            }
            else if (valorA.Length > valorB.Length)
            {
                longitud = valorB.Length;
            }
            else if (valorA.Length < valorB.Length)
            {
                longitud = valorA.Length;
            }
            return longitud;
        }

        //metodo con objetos
    }
}