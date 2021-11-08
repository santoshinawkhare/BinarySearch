using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello to BinarySearch Program!");

            /* UC1 binarySearchTree = new UC1();
             binarySearchTree.Insert(56);
             binarySearchTree.Insert(30);
             binarySearchTree.Insert(70);
             binarySearchTree.Display();*/

            /*UC2 binarySearchTree = new UC2();
            binarySearchTree.Insert(56);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(70);
            binarySearchTree.Insert(22);
            binarySearchTree.Insert(40);
            binarySearchTree.Insert(11);
            binarySearchTree.Insert(3);
            binarySearchTree.Insert(16);
            binarySearchTree.Insert(60);
            binarySearchTree.Insert(95);
            binarySearchTree.Insert(65);
            binarySearchTree.Insert(63);
            binarySearchTree.Insert(67);
            binarySearchTree.Display();
            Console.WriteLine("size of binary search tree is : " + binarySearchTree.Size());*/

            UC3<int> binarySearch = new UC3<int>(56);
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            binarySearch.Insert(22);
            binarySearch.Insert(40);
            binarySearch.Insert(60);
            binarySearch.Insert(95);
            binarySearch.Insert(11);
            binarySearch.Insert(65);
            binarySearch.Insert(3);
            binarySearch.Insert(16);
            binarySearch.Insert(63);
            binarySearch.Insert(67);
            binarySearch.Display();
            bool result = binarySearch.IfExists(63, binarySearch);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
