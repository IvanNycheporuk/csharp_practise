namespace task1
{
    public class MyList<T>:IMyList<T>
    {
        public MyList()
        {
            array = new T[20];
        }

        private T[] array;

        public int Count { get; private set; } = 0;

        public T this[int index] 
        {
            get 
            {
                return array[index];
            } 
        }

        public void Add(T a)
        {
            T[] tempArray = new T[array.Length + 1];


            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }

            tempArray[array.Length] = a;

            array = tempArray;
        }   

        public void Clear()
        {
            array = new T[20];
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if ((int)(object)array[i] == (int)(object)item)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
