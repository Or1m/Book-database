using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektPJ2
{
    class MyList<T> : IDataStructure
    {
        private T[] _array;
        private int _index;

        public MyList(int capacity = 5)
        {
            _array = new T[capacity];
            _index = 0;
        }

        public int Length { get => _index; }

        public void Add(T t)
        {
            if (isFull())
                Realloc();

            _array[_index++] = t;
        }

        public void Add(T t, int index)
        {
            if (index >= _array.Length)
                Realloc(index * 2);

            _array[index] = t;
            _index = index + 1;
        }

        public int IndexOf(T t)
        {
            for (int i = 0; i < _index; i++)
            {
                if (_array[i].Equals(t))
                    return i;
            }

            return -1;
        }

        public bool Contains(T t)
        {
            for (int i = 0; i < _index; i++)
            {
                if (_array[i].Equals(t))
                    return true;
            }

            return false;
        }

        public T Get(int index)
        {
            if (index >= _array.Length)
                throw new ApplicationException("Index out of range");
            else
                return _array[index];
        }

        public void Remove(int index)
        {
            _array[index] = default(T);
        }

        public void Remove(T t)
        {
            for (int i = 0; i < _index; i++)
            {
                if (_array[i].Equals(t))
                {
                    _array[i] = default(T);
                    break;
                }

            }
        }

        public void Clear()
        {
            for (int i = 0; i < _array.Length; i++)
                _array[i] = default(T);

            _index = 0;
        }

        public bool isEmpty()
        {
            return _index == 0;
        }

        public bool isFull()
        {
            return _index == _array.Length;
        }

        private void Realloc()
        {
            Array.Resize(ref _array, _array.Length * 2);
        }

        private void Realloc(int newSize)
        {
            Array.Resize(ref _array, newSize);
        }

        public IEnumerator GetEnumerator()
        {
            return new MyListEnum<T>(_array);
        }
    }
}