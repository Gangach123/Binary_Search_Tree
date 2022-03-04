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
            binaryTree.InsertingElements(22);
            binaryTree.InsertingElements(40);
            binaryTree.InsertingElements(60);
            binaryTree.InsertingElements(95);
            binaryTree.InsertingElements(11);
            binaryTree.InsertingElements(65);
            binaryTree.InsertingElements(3);
            binaryTree.InsertingElements(16);
            binaryTree.InsertingElements(63);
            binaryTree.InsertingElements(67);
            binaryTree.size();
        }
    }
}
