﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        public int data;
        public Node rightNode;
        public Node leftNode;

        public Node(int data)
        {
            this.data = data;
        }
    }
}
