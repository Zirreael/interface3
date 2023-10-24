using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    public class MyStack<T>
    {
        private T[] items; // элементы стека
        private int count;   // количество элементов
        const int n = 100;   // количество элементов в массиве по умолчанию
        public MyStack()
        {
            items = new T[n];
        }
        public MyStack(int length)
        {
            items = new T[length];
        }
        public bool IsEmpty
        {
            get { return count == 0; }
        }
        public int Size
        {
            get { return count; }
        }
        public void PushPrint(T item)
        {
            if (count == items.Length)
                throw new InvalidOperationException("Переполнение стека");
            items[count] = item;
            count++;
            Console.WriteLine("ok");
        }
        public void Push(T item)
        {
            if (count == items.Length)
                throw new InvalidOperationException("Переполнение стека");
            items[count] = item;
            count++;
        }
        public T Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            T item = items[count - 1];
            items[count] = default(T); // сбрасываем ссылку
            count--;
            return item;
        }
        public T Back()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            return items[count - 1];
        }
        public void Clear()
        {
            items = new T[n];
            count = 0;
            Console.WriteLine("ok");
        }
        public void Exit()
        {
            Console.WriteLine("bye");
            Environment.Exit(0);
        }
    }
}
