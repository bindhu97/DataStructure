using DataStructure.LinkedListDataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Stack
{
    internal class Stack
    {
        public Node1 top;
        public Stack()
        {
            this.top = null;
        }
        internal void Push(int data)
        {
            Node1 node = new Node1(data);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} Pushed to stack", data);
        }
    }
    internal void Display()
    {
        Node temp = this.top;
        while (temp != null)
        {
            Console.WriteLine(temp.data + " ");
            temp = temp.next;
        }
    }
    internal void Peek()
    {
        if (this.top == null)
        {
            Console.WriteLine("stack is empty");
            return;
        }
        Console.WriteLine("{0} is element on top of stack", this.top.data);
    }
    internal void Pop()
    {
        if (this.top == null)
        {
            Console.WriteLine("Stack is empty");
            return;
        }
        Console.WriteLine("data popped is {0}", this.top.data);
        this.top = this.top.next;
    }
    internal void IsEmpty()
    {
        while (this.top != null)
        {
            Peek();
            Pop();
        }
        Console.WriteLine("Stack is empty now");
    }
}
