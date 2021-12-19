using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Collections
{
    public class Deque<T> : IEnumerable, ICloneable
    {
        private DoublyNode<T>? _head = default;
        private DoublyNode<T>? _tail = default;

        public T? Head { get => _head.Data; private set { } }
        public T? Tail { get => _tail.Data; private set { } }
        public int Count { get; set; } = 0;
        public bool IsEmpty
        {
            get
            {
                if (Count == 0)
                    return true;
                else
                    return false;
            }
        }

        public void PushHead(T data)
        {
            if(data == null)
                throw new ArgumentNullException("data null");

            var node = new DoublyNode<T>(data);
            
            if(IsEmpty)
            {
                Initializer(data);
                return;
            }

      
            node.Next = _head;
            _head.Previous = node;
            _head = node;
            Count++;
            
        }
        public void PushTail(T data)
        {
            if (data == null)
                throw new ArgumentNullException("data null");

            var node = new DoublyNode<T>(data);

            if (IsEmpty)
            {
                Initializer(data);
                return;
            }

            node.Previous = _tail;
            _tail.Next = node;
            _tail = node;
            Count++;


        }
        public void PopHead()
        {
            var next = _head.Next;
            next.Previous = null;
            _head = next;
        }
        public object Clone()
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
        private void Initializer(T data)
        {         
            var node = new DoublyNode<T>(data);

            _head = node;
            _tail = node;
            Count = 1;
        }
    }
}
