using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
       
            binaryTree.Add(new Node(5));
            binaryTree.Add(new Node(7));
            binaryTree.Add(new Node(3));
            binaryTree.Add(new Node(10));
            Console.WriteLine(binaryTree.Search(6));
            Console.ReadLine();
        }
    }
}
