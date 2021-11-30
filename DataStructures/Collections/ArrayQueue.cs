using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Collections
{
    public class ArrayQueue<T>
    {
        public ArrayQueue(int size)
        {
            if (Equals(size, 0))
                throw new IndexOutOfRangeException($"{size} не является целочисленным типом данных");

            items = new T[size];
        }
        public ArrayQueue(T data, int size)
        {
            SetFirstItem(data);
        }

        private T[] items;
        private T _head => items[Count - 1];
        private T _tail => items[0];
        public int Count { get; private set; }

        /// <summary>
        /// Добавления элемента в очередь
        /// </summary>
        /// <param name="data">Данные</param>
        public void Enqueue(T data)
        {
            if (Count == 0)
            {
                SetFirstItem(data);
                return;
            }

            items[Count] = data;
            Count++;
        }

        public void Dequeue()
        {
            Array.Reverse(items, 0, Count);
            items[Count - 1] = default(T);
            Count--;
            Array.Reverse(items, 0, Count);
        }


        private void SetFirstItem(T data)
        {
            items[0] = data;
            Count++;
        }
    }
}
