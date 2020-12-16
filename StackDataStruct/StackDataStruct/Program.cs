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
        }
    }
}
