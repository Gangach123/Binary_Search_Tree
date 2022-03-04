using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class BinarySearch<T>
    {
        public T data;
        public BinarySearch<T> left;
        public BinarySearch<T> right;

        public BinarySearch(T data)
        {
            this.data = data;
        }
    }
}
