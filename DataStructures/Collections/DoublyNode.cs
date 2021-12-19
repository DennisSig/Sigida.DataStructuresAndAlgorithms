using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Collections
{
    public class DoublyNode<T>
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

        public DoublyNode<T> Previous { get; set; }
        public DoublyNode<T> Next { get; set; }
        public DoublyNode(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }

    }
}
