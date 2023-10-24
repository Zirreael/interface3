using System;

namespace stack
{
    
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> stack = new MyStack<int>();
            stack.PushPrint(3);
            stack.PushPrint(14);
            Console.WriteLine(stack.Size);
            stack.Clear();
            stack.PushPrint(1);
            Console.WriteLine(stack.Back());
            stack.PushPrint(2);
            Console.WriteLine(stack.Back());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Size);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Size);
            stack.Exit();
            
        }
    }
}
