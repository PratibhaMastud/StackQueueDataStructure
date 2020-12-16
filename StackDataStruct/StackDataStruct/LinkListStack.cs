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

        internal void Pop()
        {
            if (this.top == null)
            {
                Console.Write("Stack empty");
                return;
            }
            Console.WriteLine("\nValue poped is {0}", this.top.data);
            this.top = this.top.next;
        }

        internal void Peek()
        {
            if (this.top == null) 
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("\n{0} is in the top of the stack",this.top.data);
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

