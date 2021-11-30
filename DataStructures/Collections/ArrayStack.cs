using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Collections
{
    public class ArrayStack<T>
    {
        T[] items;
        public int Count => items.Length;
        private int _current = -1;
        private int _size = 0;

        public ArrayStack(int size)
        {
            items = new T[size];
            _size = size;
        }

        public ArrayStack(int size, T[] data)
        {
            _size = size;
            items = data;
            _current = data.Length - 1;
        }

        public void Push(T data)
        {
            if (_current < _size)
            {
                _current++;
                items[_current] = data;
            }
            else
                throw new ArgumentOutOfRangeException("StackOverFlow");
        }

        public void Pop()
        {
            if (_current >= 0)
            {
                items[_current] = default(T);
                _current--;
            }
            else
                throw new NullReferenceException();
        }

        public T[] GetArray()
        {
            return items;
        }

        public T Peek()
        {
            return items[_current];
        }

        public override string ToString()
        {
            return items.ToString();
        }

    }
}
