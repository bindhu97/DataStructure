using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.LinkedListDataStructure
{
    internal class LinkedList
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Linked List", node.data);
        }
        internal void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        internal Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid position");
            }

            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                {
                    Console.WriteLine("Position out of range");
                }
            }
            Console.WriteLine("\n inserting value: " + data + " Postion " + position);
            return head;
        }
        internal void Append(int data)
        {
            Node node2 = new Node(data);
            if (this.head == null)
            {
                this.head = node2;
            }
            else
            {
                Node temp = this.head;
                head = node2;
                head.next = temp;
            }
            Console.WriteLine(data + " added in  appending order \n ");
        }
        internal Node RemoveFirstNode()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            Console.WriteLine("First Node Removed.");
            return this.head;
        }
        internal Node RemoveLastNode()
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                head = null;
                return null;
            }
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            Console.WriteLine("Last Node Removed.");
            return head;
        }
        internal int Search(int value)
        {
            Node node = this.head;
            int count = 0;
            while (node != null)
            {
                if (node.data == value)
                {
                    return count;
                }
                node = node.next;
                count++;
            }

            if (count >= 0)
            {
                Console.WriteLine("result fount at " + count + " location");
                return count;
            }
            else
            {
                Console.WriteLine("list is empty");
                return -1;

            }
        }
        internal Node InsertAtParticularPosition1(int position, int data)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid position");
            }

            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                {
                    Console.WriteLine("Position out of range");
                }
            }
            Console.WriteLine("\n inserting value: " + data + " Postion " + position);
            return head;
        }
        internal void DeleteAtParticularPosition(int position)
        {
            Node temp = new Node(position);
            if (this.head == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }

            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.next;
            }
            if (temp == null || temp.next == null)
            {
                return;
            }
            Node next = temp.next.next;
            temp.next = next;
            Console.WriteLine("Node Deleted on" + position + " Position");
        }
        public void size()
        {
            Node temp = this.head;
            int count = 0;
            if (temp == null)
            {
                System.Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                System.Console.WriteLine(temp.data + " ");
                temp = temp.next;
                count++;
            }
            System.Console.WriteLine("linked list size is :" + count);
        }
    }
}
