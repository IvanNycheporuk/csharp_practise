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
            array[Count++] = a;            
        }   

        public void Clear()
        {

        }

        public bool Contains(T a)
        {
            return true;
        }
    }
}
