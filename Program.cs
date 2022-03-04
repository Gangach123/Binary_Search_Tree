using System;
namespace BinarySearchTree
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree Problems");
            BinaryTree<int> bst = new BinaryTree<int>();
            //Inserting elements to the binary tree
            bst.InsertingElements(56);
            bst.InsertingElements(30);
            bst.InsertingElements(70);
        }
    }
}
