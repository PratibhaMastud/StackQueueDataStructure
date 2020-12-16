using System;
using System.Collections.Generic;
using System.Text;

namespace StackDataStruct
{
    class LinkListStack
    {
        private Node top;
        public LinkListStack()
        {
            this.top = null;
        }
        public void Push(int data)
        {
            Node newnode = new Node(data);
            if (this.top == null)
            {
                newnode.next = null;
            }
            else
            {
                newnode.next = this.top;
            }
            this.top = newnode;
            Console.WriteLine("{0} pushed to stack",data);
        }

        internal void Display()
        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("Empty Linked list");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }     
    }
}

