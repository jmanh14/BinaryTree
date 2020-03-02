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
            Node nodeOne = new Node(5);
            Node nodeTwo = new Node(6);
            Node nodeThree = new Node(4);
            binaryTree.Add(nodeOne);
            binaryTree.Add(nodeTwo);
            binaryTree.Add(nodeThree);
            Console.WriteLine(binaryTree.Search(nodeTwo));
            Console.ReadLine();
        }
    }
}
