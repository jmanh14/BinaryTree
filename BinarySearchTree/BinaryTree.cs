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
        public void Add( Node node)
        {
            Node tempNode = new Node(node.data);
            if (root == null)
            {
                root = tempNode;
                return;
            }
            else
            {
                Node currentNode = root;
                Node parent;
                while (true)
                {
                    parent = currentNode;
                    if (node.data < currentNode.data)
                    {
                        currentNode = currentNode.leftNode;
                        if (currentNode == null)
                        {
                            parent.leftNode = node;
                            return;
                        }
                    }
                    else
                    {
                        currentNode = currentNode.rightNode;
                        if (currentNode == null)
                        {
                            parent.rightNode = node;
                            return;
                        }
                    }
                }
            }
            
        }
        public bool Search(Node node)
        {
            if (root == null)
                return false;
            if (root.data == node.data)
                return true;

            bool isInLeft = Search(node.leftNode);
            if (isInLeft)
                return true;

            bool isInRight = Search(node.rightNode);

            return isInRight;
        }
    }
}
