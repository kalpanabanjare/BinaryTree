using System;
using System.Collections.Generic;
namespace BinaryTree
{ 
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to binary search tree");
            Tree<int> binarySearchTree = new Tree<int>(56);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(70);
            binarySearchTree.Insert(45);
            binarySearchTree.Insert(85);
            binarySearchTree.Insert(77);
            binarySearchTree.Insert(25);
            binarySearchTree.Insert(64);

            binarySearchTree.Display();
            binarySearchTree.Getsize();
        }
    }
}
