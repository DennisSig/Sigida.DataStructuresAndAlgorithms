using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Collections
{
    public class BinaryTree<T> : ICloneable
       where T : IComparable
    {
        public bool IsLeaf
        {
            get
            {
                if (Count > 0)
                    return true;
                else
                    return false;
            }
        }
        public BinaryNode<T>? Root { get; set; }
        public int Count { get; private set; }

        /// <summary>
        /// Добавляет значение в дерево
        /// </summary>
        /// <param name="data">Данные</param>
        public void Add(T data)
        {
            if (Root == null)
            {
                AddNewRoot(data);
                return;
            }

            Root.Add(data);
            Count++;
        }

        /// <summary>
        /// Коприрует дерево
        /// </summary>
        /// <returns>Дерево</returns>
        public object Clone()
        {
            return Clone();
        }
        /// <summary>
        /// Рекурсивный инфиксный обход дерева
        /// </summary>
        /// <returns>Список значений дерева</returns>
        public List<T> Inoreder()
        {
            if (Root == null)
                return new List<T>();

            return Inorder(Root);
        }

        /// <summary>
        /// Рекурсивный постфиксный обход дерева
        /// </summary>
        /// <returns>Список значений дерева</returns>   
        public List<T> Postorder()
        {
            if (Root == null)
                return new List<T>();

            return Postorder(Root);
        }

        /// <summary>
        /// Рекурсивный постфиксный обход дерева
        /// </summary>
        /// <returns>Список значений дерева</returns>
        public List<T> Preorder()
        {
            if (Root == null)
                return new List<T>();

            return Preorder(Root);
        }
        private List<T> Postorder(BinaryNode<T> node)
        {
            var list = new List<T>();

            if (node != null)
            {
                if (node.Left != null)
                    list.AddRange(Postorder(node.Left));
                if (node.Right != null)
                    list.AddRange(Postorder(node.Right));
                list.Add(node.Data);
            }

            return list;
        }
        private List<T> Preorder(BinaryNode<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                list.Add(node.Data);
                if (node.Left != null)
                {
                    list.AddRange(Preorder(node.Left));
                }

                if (node.Right != null)
                {
                    list.AddRange(Preorder(node.Right));
                }
            }

            return list;

        }
        private List<T> Inorder(BinaryNode<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                if (node.Left != null)
                    list.AddRange(Inorder(node.Left));
                list.Add(node.Data);
                if (node.Right != null)
                    list.AddRange(Inorder(node.Right));
            }

            return list;
        }
        private void AddNewRoot(T data)
        {
            Root = new BinaryNode<T>(data);
            Count = 1;
        }
    }
}
