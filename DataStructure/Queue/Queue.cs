using DataStructure.LinkedListDataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Queue
{
    internal class Queue
    {
        Node2 head = null;

        public void Enqueue(int data)
        {
            Node2 node = new Node2(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node2 temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine(node.data + " inserted in Queue");
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }

        public void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            else
            {
                while (this.head != null)
                {
                    head.next.next = null;
                }
                head.next = head;
            }
        }
    }
}
