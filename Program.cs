using System;
namespace BinarySearchTree
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree Problems");
            BinaryTree<int> binaryTree = new BinaryTree<int>();
            //Inserting elements to the binary tree
            binaryTree.InsertingElements(56);
            binaryTree.InsertingElements(30);
            binaryTree.InsertingElements(70);
        }
    }
}
