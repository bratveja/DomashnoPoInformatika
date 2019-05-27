using System;

namespace Zadacha6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Tree();
        }

        public static void Tree()
        {
            BinaryTree konstanta = new BinaryTree();
            int[] arr = new int[] { 16, 2, 9, 3, 8, 5, 4, 11, 7, 21, 13, 29 };
            Node nodee = null;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                nodee = konstanta.insert(nodee, arr[i]);
            }
            Console.WriteLine(konstanta.MinStoinost(nodee));
            Console.WriteLine(konstanta.MaxStoinost(nodee));
        }
    }
    public class Node
    {
        public int stoinost;
        public Node min, max;

        public Node(int a)
        {
            stoinost = a;
            min = max = null;
        }
    }
    public class BinaryTree
    {
        public Node insert(Node root, int b)
        {
            if (root == null)
            {
                root = new Node(b);
            }
            else if (b < root.stoinost)
            {
                root.min = insert(root.min, b);
            }
            else
            {
                root.max = insert(root.max, b);
            }

            return root;
        }

        public int MinStoinost(Node node)
        {
            Node x = node;

            while (x.min != null)
            {
                x = x.min;
            }
            return x.stoinost;
        }
        public int MaxStoinost(Node node)
        {
            Node y = node;

            while (y.max != null)
            {
                y = y.max;
            }
            return y.stoinost;
        }
    }
}