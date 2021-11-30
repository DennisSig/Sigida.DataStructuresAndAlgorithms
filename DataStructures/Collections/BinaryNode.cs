using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Collections
{
    public class BinaryNode<T> : IComparable<T>, IComparable
       where T : IComparable
    {
        public BinaryNode(T data)
        {
            Data = data;
        }
        public BinaryNode(T data, BinaryNode<T> left, BinaryNode<T> right)
        {
            Data = data;
            Left = left;
            Right = right;
        }
        public T Data { get; set; }
        public BinaryNode<T> Left { get; private set; }
        public BinaryNode<T> Right { get; private set; }

        public void Add(T data)
        {
            var node = new BinaryNode<T>(data);

            if (node.Data.CompareTo(Data) == -1)
            {
                if (Left == null)
                    Left = node;
                else
                    Left.Add(data);
            }
            else
            {
                if (Right == null)
                    Right = node;
                else
                    Right.Add(data);
            }

        }
        public int CompareTo(object obj)
        {
            if (obj is BinaryNode<T> item)
            {
                return Data.CompareTo(item);
            }
            else
                throw new ArgumentException("Несовпадение типов");
        }
        public int CompareTo(T other)
        {
            return Data.CompareTo((T)other);
        }
    }
}
