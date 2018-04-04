namespace Programas
{
    public class ArrayList<T> : Lista<T> where T: new()
    {

        private T[] guardar { get; set; }

        public override int Length { get => guardar.Length; }

        public ArrayList(T[] arreglo)
        {
            guardar = arreglo;
        }

        public override void Push(T obj)
        {
            T[] temp = new T[guardar.Length + 1];
            for (int i = 0; i < guardar.Length; i++)
            {
                temp[i] = guardar[i];
            }
            temp[temp.Length - 1] = obj;
            guardar = temp;
        }

        public override bool Set(int i, T obj)
        {
            if (i >= Length)
                return false;

            guardar[i] = obj;
            return true;
        }

        public override bool Get(int i, out T obj)
        {
            obj = new T();
            if (i >= Length)
            {
                return false;
            }
            else
            {
                obj = guardar[i];
                return true;
            }
        }
    }
}
