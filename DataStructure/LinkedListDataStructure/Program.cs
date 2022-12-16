// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;

//namespace DataStructure.LinkedListDataStructure
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            LinkedList list = new LinkedList();
//            list.Add(56);
//            list.Add(30);
//            list.Add(70);
//            list.Display();
//            list.InsertAtParticularPosition(2, 30);
//            list.Display();
//            list.Append(70);
//            list.Append(30);
//            list.Append(56);
//            list.Display();
//            list.RemoveFirstNode();
//            list.Display();
//            list.RemoveLastNode();
//            list.Display();
//            list.Search(30);
//            list.InsertAtParticularPosition1(2, 40);
//            list.Display();
//            list.DeleteAtParticularPosition(2);
//            list.Display();
//            list.size();
//            list.Display();
//        }
//    }
//}
//using DataStructure.Stack;
//internal class Program
//{
//    public static void Main(string[] args)
//    {
//        Stack stack = new Stack();
//        stack.Push(56);
//        stack.Push(30);
//        stack.Push(70);
//        stack.Display();
//        stack.Peek();
//        stack.Pop();
//        stack.IsEmpty();
//    }
//}

using DataStructure.Queue;
internal class Program
{
    public static void Main(string[] args)
    {
        Queue queue = new Queue();
        queue.Enqueue(56);
        queue.Enqueue(30);
        queue.Enqueue(70);
    }
}