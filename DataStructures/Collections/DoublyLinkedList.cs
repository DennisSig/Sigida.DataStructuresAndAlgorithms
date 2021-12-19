using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Collections
{
    public class DoublyLinkedList<T> : IEnumerable, ICloneable
    {
        /// <summary>
        /// Создает чистый объект
        /// </summary>
        public DoublyLinkedList()
        {
            Clear();
        }
        /// <summary>
        /// Создает объект с первоначальными данными
        /// </summary>
        /// <param name="data"></param>
        public DoublyLinkedList(T data)
        {
            SetFront(data);
        }

        /// <summary>
        /// Первый элемент структуры
        /// </summary>
        public DoublyNode<T> Front { get; private set; }
        /// <summary>
        /// Последний элемент структуры
        /// </summary>
        public DoublyNode<T> End { get; private set; }
        /// <summary>
        /// Количество элементов в структуре
        /// </summary>
        public int Count { get; private set; }

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

        /// <summary>
        /// Добавляет новый элемент в конец списка
        /// </summary>
        /// <param name="data">Данные</param>
        public void AddToEnd(T data)
        {
            if (End == null)
            {
                SetFront(data);
            }
            else
            {
                var node = new DoublyNode<T>(data);

                node.Previous = End;
                End.Next = node;
                End = node;
                Count++;

            }
        }
        /// <summary>
        /// Добавляет новый элемент в начало списка
        /// </summary>
        /// <param name="data">Данные</param>
        public void AddToFront(T data)
        {
            if (End == null)
            {
                SetFront(data);
            }
            else
            {
                var node = new DoublyNode<T>(data);

                node.Next = Front;
                Front.Previous = node;
                Front = node;
                Count++;

            }
        }

        /// <summary>
        /// Удаляет последний элемент с коллекции
        /// </summary>
        public void RemoveFront()
        {
            if (Count == 1)
            {
                Clear();
                return;
            }

            if (Front != null)
            {
                Front = Front.Next;
                Front.Previous = null;
                Count--;
            }
            else
                throw new InvalidOperationException("Команда отклонена, первичный элемент не найден");
        }

        /// <summary>
        /// Удаляет последний элемент с коллекции
        /// </summary>
        public void RemoveEnd()
        {
            if (Count == 1)
            {
                Clear();
                return;
            }

            if (End != null)
            {
                End = End.Previous;
                End.Next = null;
                Count--;
            }
            else
                throw new InvalidOperationException("Команда отклонена, конечный элемент не выявлено");
        }

        /// <summary>
        /// Удаляет объект по индексу в списке
        /// </summary>
        /// <param name="data">Объект для удаления</param>
        public void DeleteByIndex(int index)
        {
            if (index <= 0 || index > Count)
                throw new ArgumentException("Индекс равен нулю или выходит за предел списка");
            else if (IsEmpty)
                throw new ArgumentException("Список пуст");
            else if (index == 1)
                RemoveFront();
            else if (index == Count)
                RemoveEnd();
            else
            {
                var current = Front;
                var count = 1;

                while (current.Next != null & count != index)
                {
                    current = current.Next;
                    count++;
                }


                current.Previous.Next = current.Next;
                current.Next.Previous = current.Previous;
                Count--;
            }
        }
        /// <summary>
        /// Находит элемент по индексу содержащийся в списке
        /// </summary>
        /// <param name="index">Индекс элемента</param>
        /// <returns></returns>
        public DoublyNode<T> FindByIndex(int index)
        {
            CheckIndexException(index);

            if (index == 1)
                return Front;
            else if (index == Count)
                return End;

            var current = Front;
            var count = 1;

            while (current.Next != null)
            {
                if (count == index)
                    return current;
                current = current.Next;
                count++;
            }

            return null;
        }

        /// <summary>
        /// Очищает список
        /// </summary>
        public void Clear()
        {
            Front = null;
            End = null;
            Count = 0;
        }
        /// <summary>
        /// Возвращает коллекцию элементов
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            var current = Front;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        /// <summary>
        /// Клонирует список
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        private void SetFront(T data)
        {
            var node = new DoublyNode<T>(data);

            Front = node;
            End = node;
            Count = 1;
        }
        private void CheckIndexException(int index)
        {
            if (index <= 0 || index > Count)
                throw new ArgumentException("Индекс равен нулю или выходит за предел списка");
        }

    }
}
