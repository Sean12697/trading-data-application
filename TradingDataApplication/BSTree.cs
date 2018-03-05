using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingDataApplication
{
    class BSTree<T> : BinTree<T> where T : IComparable
    {
        public int Height()
        {
            return height(root);
        }

        protected int height(Node<T> tree)
        {
            if (tree == null) return 0;
            else return 1 + Math.Max(height(tree.Left), height(tree.Right));
        }

        public int Count()
        {
            return count(root);
        }

        private int count(Node<T> tree)
        {
            if (tree == null) return 0;
            return (1 + (count(tree.Left)) + (count(tree.Right)));
        }

        public Boolean Contains(T item)
        {
            return contains(item, ref root);
        }

        private Boolean contains(T item, ref Node<T> root)
        {
            if (root != null)
            {
                if (item.CompareTo(root.Data) == 0) return true;
                else if (item.CompareTo(root.Data) < 0 | (item.CompareTo(root.Data) > 0)) return contains(item, ref root.Left) | contains(item, ref root.Right);
            }
            return false;
        }

        public void RemoveItem(T item)
        {
            removeItem(item, ref root);
        }

        public void removeItem(T item, ref Node<T> tree)
        {
            if (Contains(item))
            {
                if (tree != null)
                {
                    if (item.CompareTo(tree.Data) < 0)
                    {
                        removeItem(item, ref tree.Left);
                    }
                    else if (item.CompareTo(tree.Data) > 0)
                    {
                        removeItem(item, ref tree.Right);
                    }
                    else
                    {
                        if (tree.Left == null)
                        {
                            tree = tree.Right;
                        }
                        else if (tree.Right == null)
                        {
                            tree = tree.Left;
                        }
                        else
                        {
                            T root = leastItem(tree.Right);
                            tree.Data = root;
                            removeItem(tree.Data, ref tree.Right);
                        }
                    }
                }
            }
        }

        public T leastItem(Node<T> tree)
        {
            if (tree.Left == null) return tree.Data;
            else return leastItem(tree.Left);
        }

        public void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
                tree = new Node<T>(item);
            else if (item.CompareTo(tree.Data) < 0)
                insertItem(item, ref tree.Left);
            else if (item.CompareTo(tree.Data) > 0)
                insertItem(item, ref tree.Right);
        }

    }
}
