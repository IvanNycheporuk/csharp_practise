using task1;

namespace task2
{
    public static class MyClassExtention
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            var array = new T[list.Count];

            for (var i = 0; i < array.Length; i++)
            {
                array[i] = list[i];
            }

            return array;
        }
    }
}
