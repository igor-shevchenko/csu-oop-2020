using System;
using System.Collections.Generic;

namespace BinaryTreeSet
{
    [Serializable]
    class BinaryTree<T> where T : IComparable
    {
        private Node<T> root;

        public bool Add(T value)
        {
            var currentNode = root;
            while (currentNode != null)
            {
                var compareResult = value.CompareTo(currentNode.Value);
                if (compareResult < 0)
                {
                    if (currentNode.Left == null)
                    {
                        currentNode.Left = new Node<T>
                        {
                            Value = value,
                            Parent = currentNode
                        };
                        return true;
                    }

                    currentNode = currentNode.Left;
                }
                else if (compareResult > 0)
                {
                    if (currentNode.Right == null)
                    {
                        currentNode.Right = new Node<T>
                        {
                            Value = value,
                            Parent = currentNode
                        };
                        return true;
                    }

                    currentNode = currentNode.Right;
                }
                else
                {
                    return false;
                }
            }

            root = new Node<T>
            {
                Value = value
            };
            return true;
        }

        public bool Find(T value)
        {
            var currentNode = root;
            while (currentNode != null)
            {
                var compareResult = value.CompareTo(currentNode.Value);
                if (compareResult < 0)
                {
                    currentNode = currentNode.Left;
                }
                else if (compareResult > 0)
                {
                    currentNode = currentNode.Right;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        public IEnumerable<T> Traverse()
        {
            return TraverseNode(root);
        }

        private IEnumerable<T> TraverseNode(Node<T> node)
        {
            if (node == null)
                yield break;

            foreach (var value in TraverseNode(node.Left))
                yield return value;

            yield return node.Value;

            foreach (var value in TraverseNode(node.Right))
                yield return value;
        }

        public bool Remove(T value)
        {
            var currentNode = root;
            while (currentNode != null)
            {
                var compareResult = value.CompareTo(currentNode.Value);
                if (compareResult < 0)
                {
                    currentNode = currentNode.Left;
                }
                else if (compareResult > 0)
                {
                    currentNode = currentNode.Right;
                }
                else
                {
                    break;
                }
            }

            if (currentNode == null)
                return false;

            if (currentNode.Left == null && currentNode.Right == null)
            {
                if (currentNode.Parent == null)
                {
                    root = null;
                }
                else if (currentNode.Parent.Left == currentNode)
                {
                    currentNode.Parent.Left = null;
                }
                else
                {
                    currentNode.Parent.Right = null;
                }

                return true;
            }

            if (currentNode.Left == null)
            {
                currentNode.Right.Parent = currentNode.Parent;

                if (currentNode.Parent == null)
                {
                    root = currentNode.Right;
                }
                else if (currentNode.Parent.Left == currentNode)
                {
                    currentNode.Parent.Left = currentNode.Right;
                }
                else
                {
                    currentNode.Parent.Right = currentNode.Right;
                }

                return true;
            }


            if (currentNode.Right == null)
            {
                currentNode.Left.Parent = currentNode.Parent;

                if (currentNode.Parent == null)
                {
                    root = currentNode.Left;
                }
                else if (currentNode.Parent.Left == currentNode)
                {
                    currentNode.Parent.Left = currentNode.Left;
                }
                else
                {
                    currentNode.Parent.Right = currentNode.Left;
                }

                return true;
            }

            var leftmostNode = currentNode.Right;
            while (leftmostNode.Left != null)
            {
                leftmostNode = leftmostNode.Left;
            }

            currentNode.Value = leftmostNode.Value;
            if (leftmostNode.Right == null)
            {
                leftmostNode.Parent.Left = null;
            }
            else
            {
                leftmostNode.Parent.Left = leftmostNode.Right;
                leftmostNode.Right.Parent = leftmostNode.Parent;
            }

            return true;
        }
    }
}