using System;
using System.Collections;

namespace DataStructures.Collections
{
    public class Queue<T> : IEnumerable
    {
        private Node<T>? _reare;
        private Node<T>? _front;
        private Node<T>? _previos;

        /// <summary>
        /// Инициализация очереди в начальное состояние
        /// </summary>
        public Queue()
        {
            Clear();
        }

        public Queue(T data)
        {
            SetFront(data);
        }
        public int Count { get; private set; }
        public Node<T> Front => _front;
        public Node<T> Reare => _reare;
        public bool IsEmpty
        {
            get
            {
                if (Count != 0)
                    return true;
                else
                    return false;
            }
        }

        public void Enqueue(T data)
        {
            if (_front != null)
            {
                _previos = _reare;

                var node = new Node<T>(data);

                _reare.Next = null;
                _reare = node;
                _previos.Next = _reare;
                Count++;
            }
            else
            {
                SetFront(data);
            }


        }
        public void Dequeue()
        {
            if (_front.Next == null)
            {
                Clear();
                return;
            }

            _front = _front.Next;
            Count--;
        }

        public IEnumerator GetEnumerator()
        {
            while (_front != null)
            {
                yield return Front.Data;
                Dequeue();
            }

        }

        private void SetFront(T data)
        {
            var node = new Node<T>(data);
            _front = node;
            _reare = node;
            Count = 1;
        }

        public void Clear()
        {
            _reare = null;
            _front = null;
            Count = 0;
        }

        public override string ToString()
        {
            return $"В очереди находится {Count} элементов";
        }


    }
}
