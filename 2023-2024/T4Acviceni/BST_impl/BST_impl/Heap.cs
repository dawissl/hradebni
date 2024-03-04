using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST_impl
{
    
    internal class Heap
    {
        private Node root;
        public Node Root { get { return root; } set { root = value; } }

        public void Insert(int data)
        {
            root = InsertRecursive(root, data);
            // TODO Heapify() - přeskladani haldy do min/max podoby
        }

        private Node InsertRecursive(Node root, int data)
        {
            if (root == null)
            {
                root = new Node(data);
                return root;
            }

            if (root.LeftTree == null)
                root.LeftTree = InsertRecursive(root.LeftTree, data);
            else if (root.RightTree == null)
                root.RightTree = InsertRecursive(root.RightTree, data);
            else if (CountHeight(root.LeftTree) <= CountHeight(root.RightTree))
                root.LeftTree = InsertRecursive(root.LeftTree, data);
            else
                root.RightTree = InsertRecursive(root.RightTree, data);

            return root;

        }

        private int CountHeight(Node subTree)
        {
            if (subTree == null) return 0;
            return 1 + CountHeight(subTree.LeftTree) + CountHeight(subTree.RightTree);
        }

        public void InOrderPrint()
        {
            Console.WriteLine("InOrder výpis heap");
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
