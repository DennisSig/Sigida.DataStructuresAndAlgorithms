using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Collections;

namespace DataStructures.Collections
{
    public class LinkedList<T> : IEnumerable
    {
        public Node<T>? Head { get; private set; }
        public Node<T>? Tail { get; private set; }
        public int Count { get; private set; }
        public LinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public LinkedList(T data)
        {
            SetHeadAndTail(data);
        }

        public void Add(T data)
        {
            if (Tail != null)
            {
                var item = new Node<T>(data);

                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(data);
            }
        }

        public void Delete(T data)
        {
            if (Head != null)
            {
                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }

                var current = Head.Next;
                var previous = Head;

                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;

                        if (previous.Next == null)
                            Tail = previous;

                        return;
                    }
                    else
                    {
                        previous = current;
                        current = current.Next;
                    }
                }
            }
        }

        private void SetHeadAndTail(T data)
        {
            var item = new Node<T>(data);

            Head = item;
            Tail = item;
            Count = 1;
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }

        }

        public override string ToString()
        {
            return "LinkedList " + Count + " элементов";
        }
    }
}
