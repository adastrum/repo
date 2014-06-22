using System.Collections;
using System.Collections.Generic;

namespace gonzo.DataStructures
{
    class StackArray<T> : IEnumerable<T>
    {
        private T[] _array;
        private int _n;

        private void Resize(int capacity)
        {
            var copy = new T[capacity];
            for (int i = 0; i < _array.Length; i++)
            {
                copy[i] = _array[i];
            }
            _array = copy;
        }

        public void Push(T item)
        {
            if (_n == _array.Length)
            {
                Resize(_n * 2);
            }
            _array[_n++] = item;
        }

        public T Pop()
        {
            var item = _array[--_n];
            if (_n > 0 && _n < _array.Length / 4)
            {
                Resize(_array.Length / 2);
            }
            return item;
        }

        public StackArray()
        {
            _array = new T[1];
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)_array).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
