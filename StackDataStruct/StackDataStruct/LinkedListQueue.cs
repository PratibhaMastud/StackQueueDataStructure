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
                Console.WriteLine(temp.data + "-->");
                temp = temp.next;
            }
        }
    }
}
