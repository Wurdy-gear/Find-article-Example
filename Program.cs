using System;
using System.Collections.Generic;

namespace BinaryTreeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Insert(8);
            binaryTree.Insert(10);
            binaryTree.Insert(3);
            binaryTree.Insert(1);
            binaryTree.Insert(6);
            binaryTree.Insert(4);
            binaryTree.Insert(7);
            binaryTree.Insert(14);
            binaryTree.Insert(13);

            while(true)
            { 
                Console.WriteLine("\nНайти: ");
                int value = Convert.ToInt32(Console.ReadLine());
                var node = binaryTree.Find(value);
                if (node.FindValueIsNull == true)
                {
                    Console.WriteLine("\nСтатья не найдена");
                }
                else
                    Console.WriteLine("Результат: {0}", node.Data);
            }
        }

    }
}
