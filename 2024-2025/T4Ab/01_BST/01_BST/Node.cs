using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _01_BST
{
    public class Node : IComparable<Node>
    {
        private int number;
        private Node? left;
        private Node? right;

        public int Value { get { return number; } }
        public Node Left { get { return left; } set { left = value; } }
        public Node Right { get { return right; } set { right = value; } }

        public Node(int val)
        {
            number = val;
            left = null;
            right = null;
        }

        public int CompareTo(Node? other)
        {
            return Value - other.Value;
        }

        public override string ToString()
        {
            string left = (Left != null) ? Left.ToString() : "null";
            string right = (Right != null) ? Right.ToString() : "null";
            return $"[ {Value} ] - {{{left}}}, {{{right}}} ";
        }
    }
}
