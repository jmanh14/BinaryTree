using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTree
    {
        public Node root;
        
        public BinaryTree()
        {
            root = null;
        }
        public void Add( Node newNode)
        {
            Node tempNode = new Node(newNode.data);
            if (root == null)
            {
                root = tempNode;
                return;
            }
            else
            {
                Node currentNode = root;
                Node parentNode;
                while (true)
                {
                    parentNode = currentNode;
                    if (newNode.data < currentNode.data)
                    {
                        currentNode = currentNode.leftNode;
                        if (currentNode == null)
                        {
                            parentNode.leftNode = newNode;
                            return;
                        }
                    }
                    else
                    {
                        currentNode = currentNode.rightNode;
                        if (currentNode == null)
                        {
                            parentNode.rightNode = newNode;
                            return;
                        }
                    }
                }
            }
            
        }
        public bool Search(int nodeData)
        {
            Node currentNode = root;
            while (currentNode != null)
            {
                if (currentNode.data == nodeData)
                    return true;
                else if (currentNode.data > nodeData)
                {
                    currentNode = currentNode.leftNode;
                }
                else
                {
                    currentNode = currentNode.rightNode;
                }
            }
            return false;
        }
    }
}
