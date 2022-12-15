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
        public void Push(int data)
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
            System.Console.WriteLine(data + " Pushed to stack");
        }
    }
}
