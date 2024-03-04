namespace BST_impl
{
    internal class Program
    {
        static void Main(string[] args)
        {
           BinarySearchTree bst  = new BinarySearchTree();
            bst.Insert(7);
            bst.Insert(1);
            bst.Insert(3);
            bst.Insert(4);
            bst.Insert(5);
            bst.Insert(6);
            bst.Insert(2);
            bst.InOrderPrint();
            Console.WriteLine("---------------------------");
            Heap heap = new Heap();
            heap.Insert(7);
            heap.Insert(1);
            heap.Insert(3);
            heap.Insert(4);
            heap.Insert(5);
            heap.Insert(6);
            heap.Insert(2);
            heap.InOrderPrint();
            

        }
    }
}