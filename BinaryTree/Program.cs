using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Tree Problem!");

            BinaryTree<int> binarySearch = new BinaryTree<int>(56);

            //Add Elements
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            binarySearch.Display();
            Console.ReadLine();

           
        }
    }
}
