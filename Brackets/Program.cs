using System;

namespace Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите арифметическое выражение");
            string str = Console.ReadLine();
            MyStack<char> stack = new MyStack<char>();
            for(int i=0; i<str.Length; i++)
            {
                if(str[i] == '(')
                {
                    stack.Push(str[i]);
                }
                if (str[i] == ')')
                {
                    if (stack.IsEmpty)
                    {
                        Console.WriteLine("no");
                        Console.WriteLine("position is " + (i+1));
                        Environment.Exit(0);
                        break;
                    }
                    else
                        stack.Pop();
                }
            }
            if (stack.IsEmpty)
                Console.WriteLine("yes");
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("count is " + stack.Size);
            }
        }
    }
}
