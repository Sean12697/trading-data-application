using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingDataApplication
{
    class AVLTree<T> : BSTree<T> where T : IComparable
    {
        public new void InsertItem(T item)
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
            tree.BalanceFactor = height(tree.Left) - height(tree.Right);
            if (tree.BalanceFactor <= -2)
                rotateLeft(ref tree);
            if (tree.BalanceFactor >= 2)
                rotateRight(ref tree);
        }


        private void rotateLeft(ref Node<T> tree)
        {
            if (tree.Right.BalanceFactor > 0)  //double rotate
                rotateRight(ref tree.Right);
            else
            {
                Node<T> oldRoot = tree;
                Node<T> newRoot = tree.Right;
                oldRoot.Right = newRoot.Left;
                newRoot.Left = oldRoot;
                tree = newRoot;
                tree.BalanceFactor = height(tree.Left) - height(tree.Right);
            }
        }


        private void rotateRight(ref Node<T> tree)
        {
            if (tree.Left.BalanceFactor < 0)  //double rotate
                rotateLeft(ref tree.Left);
            else
            {
                Node<T> oldRoot = tree;
                Node<T> newRoot = tree.Left;
                oldRoot.Left = newRoot.Right;
                newRoot.Right = oldRoot;
                tree = newRoot;
                tree.BalanceFactor = height(tree.Left) - height(tree.Right);
            }
        }

        // EXTRA OVERLOADED WITH STRINGS

        public T GetItem(String item)
        {
            return GetItem(item, ref root);
        }

        private T GetItem(String item, ref Node<T> root)
        {
            if (root != null) {
                if (item.ToString().CompareTo(root.Data.ToString()) == 0) return root.Data;
                else if (item.ToString().CompareTo(root.Data.ToString()) < 0) return GetItem(item, ref root.Left);
                else if (item.ToString().CompareTo(root.Data.ToString()) > 0) return GetItem(item, ref root.Right);
            } return default(T);
        }

        public Boolean Contains(String item)
        {
            return contains(item, ref root);
        }

        private Boolean contains(String item, ref Node<T> root)
        {
            if (root != null) {
                if (item.CompareTo(root.Data.ToString()) == 0) return true;
                else if (item.CompareTo(root.Data.ToString()) < 0 | (item.CompareTo(root.Data.ToString()) > 0)) return contains(item, ref root.Left) | contains(item, ref root.Right);
            } return false;
        }

        public void RemoveItem(String item)
        {
            removeItem(item, ref root);
        }

        public void removeItem(String item, ref Node<T> tree)
        {
            if (Contains(item))
            {
                if (tree != null)
                {
                    if (item.CompareTo(tree.Data.ToString()) < 0)
                    {
                        removeItem(item, ref tree.Left);
                    }
                    else if (item.CompareTo(tree.Data.ToString()) > 0)
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
    }
}
