using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Collections
{
    public class DoublyLinkedListNode<T>
    {
        private T _data = default(T);

        public T Data
        {
            get => _data;
            set
            {
                if (value != null)
                    _data = value;
                else
                    throw new ArgumentNullException(nameof(value));
            }
        }

        public DoublyLinkedListNode<T> Previous { get; set; }
        public DoublyLinkedListNode<T> Next { get; set; }
        public DoublyLinkedListNode(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }

    }
}
