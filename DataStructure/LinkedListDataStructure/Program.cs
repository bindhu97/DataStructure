// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;

namespace DataStructure.LinkedListDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            list.InsertAtParticularPosition(2, 30);
            list.Display();
            list.Append(70);
            list.Append(30);
            list.Append(56);
            list.Display();
            list.RemoveFirstNode();
            list.Display();
            list.RemoveLastNode();
            list.Display();
        }
    }
}
