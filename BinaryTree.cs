using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class BinaryTree<T>
    {
        public BinarySearch<T> rootNode;
        int leftCounter = 0;
        int rightCounter = 0;

        //For inserting the node in Binary Tree.
        public void InsertingElements(T data)
        {
            BinarySearch<T> node = new BinarySearch<T>(data);
            if (rootNode == null)
            {
                rootNode = node;
                Console.WriteLine($"{node.data} root node is added");
            }
            else
            {
                BinarySearch<T> temp = rootNode;

                while (temp != null)
                {
                    if (Comparer<T>.Default.Compare(temp.data, node.data) < 1)
                    {
                        if (temp.right == null)
                        {
                            temp.right = node;
                            rightCounter++;
                            Console.WriteLine($"{node.data} is added to right side of {temp.data}");
                            break;
                        }
                        temp = temp.right;
                    }
                    else
                    {
                        if (temp.left == null)
                        {
                            temp.left = node;
                            leftCounter++;
                            Console.WriteLine($"{node.data} is added to left side of {temp.data}");
                            break;
                        }
                        temp = temp.left;
                    }
                }
            }
        }

        //For calculating the size of Binary Tree.
        public void size()
        {
            Console.WriteLine($"The size of Binary tree is {leftCounter + rightCounter + 1}");
        }
        public void Search(T data)
        {
            if (rootNode == null)
            {
                Console.WriteLine("Binary Tree is not available");
            }
            else
            {
                BinarySearch<T> temp = rootNode;
                bool ifFound = false;
                while (temp.left != null || temp.right != null)
                {
                    if (Comparer<T>.Default.Compare(temp.data, data) < 1)
                    {
                        if (temp.right.data.Equals(data))
                        {
                            Console.WriteLine($"{data} is found at below right of {temp.data} in the Binary Tree");
                            ifFound = true;
                            break;
                        }
                        temp = temp.right;
                    }
                    else
                    {
                        if (temp.left.data.Equals(data))
                        {
                            Console.WriteLine($"{data} is found at below left of {temp.data} in the Binary Tree");
                            ifFound = true;
                            break;
                        }
                        temp = temp.left;
                    }
                }
                if (ifFound == false)
                {
                    Console.WriteLine($"{data} is not available in this binary tree");
                }
            }
        }
    }
}
