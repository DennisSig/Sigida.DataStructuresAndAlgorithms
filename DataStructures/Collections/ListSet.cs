using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Collections
{
    public class ListSet<T> : ISet<T>, ICloneable
        where T : IEquatable<T>
    {
        public ListSet()
        {
            items = new List<T>();
        }

        public ListSet(IEnumerable<T> collections)
        {
            items = new List<T>(collections);
        }
        public List<T> items { get; private set; }
        public int Count { get => items.Capacity; }
        public object this[int index] { get => items[index]; }
        public bool IsReadOnly => false;

        public bool Add(T item)
        {
            if (items.Contains(item))
                return false;

            items.Add(item);
            return true;
        }

        public void Clear()
        {
            items.Clear();
        }

        public bool Contains(T item)
        {
            if (items.Contains(item))
                return true;
            else
                return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (arrayIndex > array.Length)
                return;
            var oldArray = items.ToArray();

            for (int i = arrayIndex, j = 0; i < oldArray.Length; i++, j++)
            {
                array[j] = oldArray[i];
            }
        }

        public void ExceptWith(IEnumerable<T> other)
        {
            foreach (var item in other)
            {
                if (items.Contains(item))
                    items.Remove(item);
                continue;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in items)
            {
                yield return item;
            }
        }

        public void DiferenseWith(IEnumerable<T> other)
        {
            var resultList = new List<T>();

            foreach (var valueSecond in other)
            {
                if (IsUnique(valueSecond))
                    resultList.Add(valueSecond);
            }

            items = resultList;
        }
        public void IntersectWith(IEnumerable<T> other)
        {
            var resultList = new List<T>();

            foreach (var valueSecond in other)
            {
                if (!IsUnique(valueSecond))
                    resultList.Add(valueSecond);
            }

            items = resultList;
        }

        public bool IsProperSubsetOf(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool IsProperSupersetOf(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool IsSubsetOf(IEnumerable<T> other)
        {
            foreach (var item in other)
            {
                if (items.Contains(item))
                    continue;
                return false;
            }
            return true;
        }

        public bool IsSupersetOf(IEnumerable<T> other)
        {
            foreach (var item in other)
            {
                if (items.Contains(item))
                    continue;
                return false;
            }
            return true;
        }

        public bool Overlaps(IEnumerable<T> other)
        {
            foreach (var item in other)
            {
                if (!IsUnique(item))
                    return true;
            }
            return false;
        }

        public bool Remove(T item)
        {
            foreach (var value in items)
            {
                if (value.Equals(item))
                {
                    items.Remove(value);
                    return true;
                }
            }

            return false;
        }

        public bool SetEquals(IEnumerable<T> other)
        {
            return items.Equals(other);
        }

        public void SymmetricExceptWith(IEnumerable<T> other)
        {
            foreach (var valueSecond in other)
            {
                if (!IsUnique(valueSecond))
                {
                    items.Remove(valueSecond);
                    continue;
                }
                items.Add(valueSecond);
            }
        }

        public void UnionWith(IEnumerable<T> other)
        {
            foreach (var valueSecond in other)
            {
                if (IsUnique(valueSecond))
                    items.Add(valueSecond);
            }
        }
        public object Clone()
        {
            return new ListSet<T>(items);

        }
        void ICollection<T>.Add(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private bool IsUnique(T item)
        {
            foreach (var value in items)
            {
                if (item.Equals(value))
                    return false;
                continue;
            }
            return true;
        }
    }
}
