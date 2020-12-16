using System;
using System.Collections.Generic;
using System.Text;

namespace StackDataStruct
{
    class LinkedListQueue
    {
        internal Node head;
       /// <summary>
       /// Enqueue the Queue
       /// </summary>
       /// <param name="data"></param>
        internal void Enqueue(int data)
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
            Console.WriteLine("{0} added into the Queue", node.data);
        }

        /// <summary>
        /// View Queue
        /// </summary>
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("\nQueue is Empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + "-->");
                temp = temp.next;
            }
        }
        /// <summary>
        /// Dequeue Elements from the Queue
        /// </summary>
        internal void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Console.WriteLine("\n{0} is Dequeued from the Queue ", head.data);
                head = head.next;
            }
        }
    }
}
