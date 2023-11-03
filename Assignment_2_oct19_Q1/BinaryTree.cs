using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oct19_Q1
{
    class BinaryTree<T> where T : IComparable<T>
    {
        private Node<T> root;

        public BinaryTree()
        {
            root = null;
        }

        public void Insert(T data)
        {
            root = InsertNode(root, data);
            Console.WriteLine($"Inserted: {data}");
        }

        private Node<T> InsertNode(Node<T> node, T data)
        {
            if (node == null)
            {
                return new Node<T>(data);
            }

            if (data.CompareTo(node.Data) < 0)
            {
                node.Left = InsertNode(node.Left, data);
            }
            else if (data.CompareTo(node.Data) > 0)
            {
                node.Right = InsertNode(node.Right, data);
            }

            return node;
        }

        public void InorderTraversal()
        {
            Console.Write("Inorder Traversal: ");
            Inorder(root);
            Console.WriteLine();
        }

        private void Inorder(Node<T> node)
        {
            if (node != null)
            {
                Inorder(node.Left);
                Console.Write(node.Data + " ");
                Inorder(node.Right);
            }
        }

        public bool Search(T data)
        {
            return SearchNode(root, data);
        }

        private bool SearchNode(Node<T> node, T data)
        {
            if (node == null)
            {
                return false;
            }

            if (data.CompareTo(node.Data) == 0)
            {
                return true;
            }

            if (data.CompareTo(node.Data) < 0)
            {
                return SearchNode(node.Left, data);
            }

            return SearchNode(node.Right, data);
        }
    }
}
