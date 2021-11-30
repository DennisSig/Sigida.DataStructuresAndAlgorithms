using System.Collections;

namespace DataStructures.Collections
{
    public class Stack<T> : IEnumerable
    {
        public Node<T>? Top { get; set; }
        private Node<T>? _previos { get; set; }
        public int Count { get; private set; }

        public Stack()
        {
            Top = null;
            Count = 0;
        }

        public void Push(T data)
        {
            if (Top == null)
            {
                var item = new Node<T>(data);

                Top = item;
                Count = 1;

                return;
            }
            else
            {
                _previos = Top;

                var item = new Node<T>(data);

                Top = item;
                Top.Next = _previos;
                Count++;
            }


        }

        /// <summary>
        /// Удаление первого элемента из стека
        /// </summary>
        public void Pop()
        {
            if (Top != null)
            {
                if (Top.Next == null)
                    Clear();
                else
                    Top = Top.Next;
            }
            else
                throw new ArgumentNullException("Стек пустой");
        }

        public void Clear()
        {
            Top = null;
            _previos = null;
            Count = 0;
        }

        public IEnumerator GetEnumerator()
        {
            while (Top != null)
            {
                yield return Top.Data;
                Pop();
            }

        }
    }
}
