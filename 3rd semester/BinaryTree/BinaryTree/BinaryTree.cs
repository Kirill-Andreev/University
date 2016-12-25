using System;
using System.Collections;
using System.Collections.Generic;

namespace BinaryTreeNameSpace
{
    /// <summary>
    /// Implementation of binary tree with enumerator
    /// </summary>
    public class BinaryTree<T> : IBinaryTree<T>, IEnumerable<T> where T : IComparable<T>
    {
        private Node root;

        public void Add(T element)
        {
            if (root == null || root.Element.Equals(element))
            {
                root = new Node(element);
            }
            else
            {
                Add(element, root);
            }
        }

        public bool Remove(T value)
        {
            Node current, parent;
            
            current = FindWithParent(value, out parent);

            if (current == null)
            {
                return false;
            }
            
            if (current.Right == null)
            {
                if (parent == null)
                {
                    root = current.Left;
                }
                else
                {
                    int result = parent.Element.CompareTo(current.Element);
                    if (result > 0)
                    {
                        parent.Left = current.Left;
                    }
                    else if (result < 0) 
                    {
                        parent.Right = current.Left;
                    }
                }
            } 
            else if (current.Right.Left == null)
            {
                current.Right.Left = current.Left;
                if (parent == null)
                {
                    root = current.Right;
                }
                else
                {
                    int result = parent.Element.CompareTo(current.Element);
                    if (result > 0)
                    {
                        parent.Left = current.Right;
                    }
                    else if (result < 0) 
                    { 
                        parent.Right = current.Right;
                    }
                }
            }
            else
            {
                Node leftmost = current.Right.Left;
                Node leftmostParent = current.Right;
                while (leftmost.Left != null)
                {
                    leftmostParent = leftmost;
                    leftmost = leftmost.Left;
                }
 
                leftmostParent.Left = leftmost.Right;
                leftmost.Left = current.Left;
                leftmost.Right = current.Right;
                if (parent == null)
                {
                    root = leftmost;
                }
                else
                {
                    int result = parent.Element.CompareTo(current.Element);
                    if (result > 0)
                    {
                        parent.Left = leftmost;
                    }
                    else if (result < 0)
                    {
                        parent.Right = leftmost;
                    }
                }
            }

            return true;
        }

        public bool Contains(T value)
        {
            Node parent;
            return FindWithParent(value, out parent) != null;
        }

        /// <summary>
        /// Recursively prints the element of tree in ascending order
        /// </summary>
        public void PrintTree()
        {
            PrintNode(root);
        }

        /// <summary>
        /// Recursively prints the element of node
        /// </summary>
        /// <param name="node"></param>
        private void PrintNode(Node node)
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty!");
                return;
            }

            if (node.Left != null)
            {
                PrintNode(node.Left);
            }

            Console.WriteLine(node.Element);
            if (node.Right != null)
            {
                PrintNode(node.Right);
            }
        }

        /// <summary>
        /// Recursive adding
        /// </summary>
        /// <param name="element"></param>
        /// <param name="root"></param>
        private void Add(T element, Node root)
        {
            if (root.Left == null && root.Element.CompareTo(element) > 0)
            {
                root.Left = new Node(element);
                return;
            }

            if (root.Right == null && root.Element.CompareTo(element) < 0)
            {
                root.Right = new Node(element);
                return;
            }

            if (root.Element.CompareTo(element) > 0)
            {
                Add(element, root.Left);
            }
            else
            {
                Add(element, root.Right);
            }
        }

        /// <summary>
        /// Search and returns the node with the specified element
        /// </summary>
        /// <param name="element"></param>
        /// <param name="parent"></param>
        /// <returns></returns>
        private Node FindWithParent(T element, out Node parent)
        {
            Node current = root;
            parent = null;

            while (current != null)
            {
                int result = current.Element.CompareTo(element);

                if (result > 0)
                {
                    parent = current;
                    current = current.Left;
                }
                else if (result < 0)
                {
                    parent = current;
                    current = current.Right;
                }
                else
                {
                    break;
                }
            }

            return current;
        }

        /// <summary>
        /// Class of tree node
        /// </summary>
        /// <typeparam name="T"></typeparam>
        private class Node
        {
            public Node(T element)
            {
                Element = element;
            }

            public Node Left { get; set; }

            public Node Right { get; set; }

            public T Element { get; set; }
        }

        /// <summary>
        /// Implementation of GetEnumerator()
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            return new BinaryTreeEnumerator(this);
        }

        /// <summary>
        /// Method required to implement
        /// the interface IEnumerable
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Implementation of binary tree enumerator
        /// </summary>
        private class BinaryTreeEnumerator : IEnumerator<T>
        {
            private BinaryTree<T> binaryTree;
            private List<T> list;
            private int index = -1;

            public BinaryTreeEnumerator(BinaryTree<T> binaryTree)
            {
                this.binaryTree = binaryTree;
                list = new List<T>();
                ListOfTreeNodes(binaryTree.root);
            }

            T IEnumerator<T>.Current
            {
                get
                {
                    return list[index];
                }
            }

            /// <summary>
            /// Returns current position
            /// </summary>
            public object Current
            {
                get
                {
                    return Current;
                }
            }

            /// <summary>
            /// Sets current position on the root of the tree
            /// </summary>
            public void Reset()
            {
                index = -1;
            }

            public bool MoveNext()
            {
                if (index < list.Count - 1)
                {
                    ++index;
                    return true;
                }

                return false;
            }

            void IDisposable.Dispose()
            {
            }

            /// <summary>
            /// Makes the list of tree nodes
            /// </summary>
            /// <param name="node"></param>
            private void ListOfTreeNodes(Node node)
            {
                if (node != null)
                {
                    if (node.Right != null)
                    {
                        ListOfTreeNodes(node.Right);
                    }

                    if (node.Left != null)
                    {
                        ListOfTreeNodes(node.Left);
                    }

                    list.Add(node.Element);
                }
            }
        }
    }
}
