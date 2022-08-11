using System;
using System.Collections.Generic;
using GenericList;

namespace GenericShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GenericList<int> NewList = new GenericList<int>();


            NewList.InsertItem(5);

            ;
        }
    }
}
