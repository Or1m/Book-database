using System;
using System.Collections;

namespace ProjektPJ2
{
    internal class MyListEnum<T> : IEnumerator
    {
        private T[] _array;
        int position = -1;

        public MyListEnum(T[] array)
        {
            _array = array;
        }
        object IEnumerator.Current {
            get {
                return Current;
            }
        }

        public T Current {
            get {
                try
                {
                    return _array[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public bool MoveNext()
        {
            return (++position < _array.Length);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}