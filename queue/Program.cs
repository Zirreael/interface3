using System;

namespace queue
{
    
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue q = new MyQueue();
            q.Push(1);
            q.Push(2);
            Console.WriteLine(q.Front());
            Console.WriteLine(q.Pop());
            Console.WriteLine(q.Pop());
            Console.WriteLine(q.Front());
            q.Exit();
        }
    }
}
