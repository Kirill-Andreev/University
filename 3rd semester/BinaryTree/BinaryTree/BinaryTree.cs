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
            if (root == null)
            {
                root = new Node(element);
            }
            else
            {
                if (root.Element.Equals(element))
                {
                    return;
                }

                Add(element, root);
            }
        }

        public bool Remove(T value)
        {
            Node parent = null;
            Node current = new Node(root.Element);
            Tuple<Node, Node> curAndPar = FindWithParent(value, parent);

            if (curAndPar.Item1 == null)
            {
                return false;
            }
            
            if (curAndPar.Item1.Right == null)
            {
                if (curAndPar.Item2 == null)
                {
                    root = curAndPar.Item1.Left;
                }
                else
                {
                    int result = curAndPar.Item2.Element.CompareTo(curAndPar.Item1.Element);
                    if (result > 0)
                    {
                        curAndPar.Item2.Left = curAndPar.Item1.Left;
                    }
                    else if (result < 0) 
                    {
                        curAndPar.Item2.Right = curAndPar.Item1.Left;
                    }
                }
            } 
            else if (curAndPar.Item1.Right.Left == null)
            {
                curAndPar.Item1.Right.Left = curAndPar.Item1.Left;
                if (curAndPar.Item2 == null)
                {
                    root = curAndPar.Item1.Right;
                }
                else
                {
                    int result = curAndPar.Item2.Element.CompareTo(curAndPar.Item1.Element);
                    if (result > 0)
                    {
                        curAndPar.Item2.Left = curAndPar.Item1.Right;
                    }
                    else if (result < 0) 
                    {
                        curAndPar.Item2.Right = curAndPar.Item1.Right;
                    }
                }
            }
            else
            {
                Node leftmost = curAndPar.Item1.Right.Left;
                Node leftmostParent = curAndPar.Item1.Right;
                while (leftmost.Left != null)
                {
                    leftmostParent = leftmost;
                    leftmost = leftmost.Left;
                }
 
                leftmostParent.Left = leftmost.Right;
                leftmost.Left = curAndPar.Item1.Left;
                leftmost.Right = curAndPar.Item1.Right;
                if (curAndPar.Item2 == null)
                {
                    root = leftmost;
                }
                else
                {
                    int result = curAndPar.Item2.Element.CompareTo(curAndPar.Item1.Element);
                    if (result > 0)
                    {
                        curAndPar.Item2.Left = leftmost;
                    }
                    else if (result < 0)
                    {
                        curAndPar.Item2.Right = leftmost;
                    }
                }
            }

            return true;
        }

        public bool Contains(T value)
        {
            Node parent = null;
            Node current = new Node(root.Element);
            Tuple<Node, Node> curAndPar = new Tuple<Node, Node>(current, parent);
            curAndPar = FindWithParent(value, curAndPar.Item2);
            return curAndPar.Item1 != null;
        }

        /// <summary>
        /// Recursively prints the element of tree in ascending order
        /// </summary>
        public void PrintTree()
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty!");
                return;
            }

            PrintNode(root);
        }

        /// <summary>
        /// Recursively prints the element of node
        /// </summary>
        /// <param name="node"></param>
        private void PrintNode(Node node)
        {
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
                if (root.Left.Element.Equals(element))
                {
                    return;
                }

                Add(element, root.Left);
            }
            else
            {
                if(root.Right.Element.Equals(element))
                {
                    return;
                }

                Add(element, root.Right);
            }
        }

        /// <summary>
        /// Search and returns the node with the specified element
        /// </summary>
        /// <param name="element"></param>
        /// <param name="parent"></param>
        /// <returns></returns>
        private Tuple<Node, Node> FindWithParent(T element, Node parent)
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

            return new Tuple<Node, Node>(current, parent);
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
