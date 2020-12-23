using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class MyClass<T> where T : new ()
    {
        public T FactoryMethod()
        {
            return new T();
        }
    }
}
