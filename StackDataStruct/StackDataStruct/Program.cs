using System;

namespace StackDataStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkListStack linkListstack = new LinkListStack();
            linkListstack.Push(70);
            linkListstack.Push(30);
            linkListstack.Push(56);
            linkListstack.Display();
            linkListstack.Pop();
            linkListstack.Display();
            linkListstack.Peek();
            linkListstack.Display();
            Console.WriteLine("\n\nQueue Data Structure :");
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            linkedListQueue.Display();
            linkedListQueue.Dequeue();
            linkedListQueue.Display();
        }
    }
}
