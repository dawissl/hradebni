using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST_impl
{
    internal class Node
    {
        private int data;
        private Node left = null;
        private Node right = null;

        public Node RightTree { get { return right; } set { right = value; } }
        public Node LeftTree { get { return left; } set { left = value; } }
        public int Data { get { return data; } set { data = value; } }

        public Node(int data)
        {
            this.data = data;
        }

        public override string ToString()
        {

            return $" {data} ";

        }
    }
}
