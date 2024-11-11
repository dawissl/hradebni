using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BST
{
    public class BinarySearchTree
    {
        private Node root;

        public Node Root { get { return root; } }
        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(Node n, int val)
        {
            if (n == null)
            {
                root = new Node(val);
            }
            else
            {
                if (root.Value < val)
                {
                    if (root.Left == null)
                    {
                        root.Left = new Node(val);
                    }
                    else
                    {
                        Insert(root.Left, val);
                    }
                }
                else if (root.Value > val)
                {
                    if (root.Right == null)
                    {
                        root.Right = new Node(val);
                    }
                    else
                    {
                        Insert(root.Right, val);
                    }
                }
            }
        }

        public bool Search(Node n, int val)
        {

            if (n == null) return false;
            if (n.Value == val) return true;
            if (n.Value < val)
                return Search(n.Right, val);
            else
                return Search(n.Left, val);

        }

        public string Print(Node n)
        {
            string output = "";

            if(n != null)
            {
                output += root.ToString() + Environment.NewLine;
                if (n.Left != null) output += Print(n.Left);
                if(n.Right != null) output += Print(n.Right);
            }

            return output;

        }
    }
}
