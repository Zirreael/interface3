using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    public class MyQueue
    {
        private int[] items; // элементы очереди
        private int count;   // количество элементов
        const int n = 100;   // количество элементов в массиве по умолчанию
        private int front = -1;
        private int tail = -1;
        public MyQueue()
        {
            items = new int[n];
        }
        public MyQueue(int length)
        {
            items = new int[length];
        }
        public bool IsEmpty
        {
            get { return count == 0; }
        }
        public int Size
        {
            get { return count; }
        }
        public void Push(int item)
        {
            if (count == items.Length)
                Console.WriteLine("error");
            items[++tail] = item;
            count++;
            Console.WriteLine("ok");
        }
        public int Pop()
        {
            if (IsEmpty)
            {
                Console.WriteLine("error");
                return -1;
            }
            int item = items[++front];
            count--;
            if (front == tail)
            {
                front = -1;
                tail = -1;
            }
            return item;
        }
        public int Front()
        {
            if (IsEmpty)
            {
                Console.WriteLine("error");
                return -1;
            }
            return items[front + 1];
        }
        public void Clear()
        {
            items = new int[n];
            count = 0;
            front = tail = -1;
            Console.WriteLine("ok");
        }
        public void Exit()
        {
            Console.WriteLine("bye");
            Environment.Exit(0);
        }
    }
}
