using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST_impl
{
    internal class BinarySearchTree
    {
        private Node root;
        public Node Root { get { return root; } set { root = value; } }

        public void Insert(int data)
        {
            root = RecursiveInsert(Root, data);
        }

        public Node RecursiveInsert(Node root, int data)
        {
            if (root == null)
            {
                root = new Node(data);
                return root;
            }

            if (data < root.Data)
            {
                root.LeftTree = RecursiveInsert(root.LeftTree, data);
            }
            else
            {
                root.RightTree = RecursiveInsert(root.RightTree, data);
            }
            return root;
        }

        public void InOrderPrint()
        {
            Console.WriteLine("InOrder výpis BST");
            RecursiveInOrder(root);
        }

        private void RecursiveInOrder(Node root)
        {
            if (root != null)
            {
                // levy podstrom
                RecursiveInOrder(root.LeftTree);
                //střed (kořen)
                Console.WriteLine(root.Data);
                //pravy podstrom
                RecursiveInOrder(root.RightTree);
            }
        }
        
    }
}
