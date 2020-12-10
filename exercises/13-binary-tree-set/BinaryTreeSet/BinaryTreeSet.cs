using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BinaryTreeSet
{
    [Serializable]
    public class BinaryTreeSet<T> : ISet<T> where T: IComparable
    {
        private BinaryTree<T> tree = new BinaryTree<T>();

        public IEnumerator<T> GetEnumerator()
        {
            return tree.Traverse().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool Add(T item)
        {
            return ((ISet<T>) this).Add(item);
        }

        void ICollection<T>.Add(T item)
        {
            tree.Add(item);
        }

        public void UnionWith(IEnumerable<T> other)
        {
            other.ToList().ForEach(x => tree.Add(x));
        }

        public void IntersectWith(IEnumerable<T> other)
        {
            var currentItems = tree.Traverse().ToList();
            var otherItems = other.Distinct().ToList();

            foreach (var currentItem in currentItems)
            {
                if (!otherItems.Contains(currentItem))
                {
                    tree.Remove(currentItem);
                }
            }
        }

        public void ExceptWith(IEnumerable<T> other)
        {
            other.ToList().ForEach(x => tree.Remove(x));
        }

        public void SymmetricExceptWith(IEnumerable<T> other)
        {
            var currentItems = tree.Traverse().ToList();
            var otherItems = other.Distinct().ToList();

            foreach (var currentItem in currentItems)
            {
                if (otherItems.Contains(currentItem))
                {
                    tree.Remove(currentItem);
                }
                else
                {
                    tree.Add(currentItem);
                }
            }
        }

        public bool IsSubsetOf(IEnumerable<T> other)
        {
            var currentItems = tree.Traverse().ToList();
            var otherItems = other.Distinct().ToList();

            return currentItems.All(item => otherItems.Contains(item));
        }

        public bool IsSupersetOf(IEnumerable<T> other)
        {
            var currentItems = tree.Traverse().ToList();
            var otherItems = other.Distinct().ToList();

            return otherItems.All(item => currentItems.Contains(item));
        }

        public bool IsProperSupersetOf(IEnumerable<T> other)
        {
            var otherItems = other.Distinct().ToList();
            return IsSupersetOf(otherItems) && otherItems.Count < Count;
        }

        public bool IsProperSubsetOf(IEnumerable<T> other)
        {
            var otherItems = other.Distinct().ToList();
            return IsSubsetOf(otherItems) && otherItems.Count > Count;
        }

        public bool Overlaps(IEnumerable<T> other)
        {
            var currentItems = tree.Traverse().ToList();
            var otherItems = other.Distinct().ToList();

            return otherItems.Any(item => currentItems.Contains(item));
        }

        public bool SetEquals(IEnumerable<T> other)
        {
            var otherItems = other.Distinct().ToList();
            return IsSubsetOf(otherItems) && IsSupersetOf(otherItems);
        }

        bool ISet<T>.Add(T item)
        {
            return tree.Add(item);
        }

        public void Clear()
        {
            tree = new BinaryTree<T>();
        }

        public bool Contains(T item)
        {
            return tree.Find(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            foreach (var value in tree.Traverse())
                array[arrayIndex++] = value;
        }

        public bool Remove(T item)
        {
            return tree.Remove(item);
        }

        public int Count => tree.Traverse().Count();
        public bool IsReadOnly => false;
    }
}