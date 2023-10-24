using System;

namespace deque
{
    public class DoublyNode<T>
    {
        public DoublyNode(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public DoublyNode<T> Previous { get; set; }
        public DoublyNode<T> Next { get; set; }
    }

    public class MyDeque<T>
    {
        DoublyNode<T> head; // головной/первый элемент
        DoublyNode<T> tail; // последний/хвостовой элемент
        int count;
        public void AddLast(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);
            if (count == 0)
                tail = head = node;
            else
            {
                tail.Next = node;
                node.Previous = tail;
                tail = node;
            }
            count++;
        }
        public void AddFirst(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);
            if (count == 0)
                head = tail = node;
            else
            {
                head.Previous = node;
                node.Next = head;
                head = node;
            }
            count++;
        }
        public T DeleteFirst()
        {
            if (count == 0)
                throw new InvalidOperationException();
            T output = head.Data;
            head = head.Next;
            head.Previous = null;
            count--;
            return output;
        }
        public T DeleteLast()
        {
            if (count == 0)
                throw new InvalidOperationException();
            T output = tail.Data;
            tail = tail.Previous;
            tail.Next = null;
            count--;
            return output;
        }
        public void Delete(T data)
        {
            if (count == 0)
                throw new InvalidOperationException();
            DoublyNode<T> node = head;
            for (int i = 0; i < count; i++)
            {
                if (node.Data.Equals(data))
                {
                    DoublyNode<T> prev = node.Previous;
                    DoublyNode<T> next = node.Next;
                    if (prev == null)
                    { 
                        next.Previous = null;
                        head = next;
                    }
                    if(next == null)
                    {
                        prev.Next = null;
                        tail = prev;
                    }
                    if (next != null && prev != null)
                    {
                        prev.Next = next;
                        next.Previous = prev;
                    }
                    break;
                }
                node = node.Next;
            }
            count--;
        }
        public int Find(T data)
        {
            if (count == 0)
                throw new InvalidOperationException();
            int index = -1;
            DoublyNode<T> node = head;
            for(int i=0; i<count; i++)
            {
                if(node.Data.Equals(data))
                {
                    index = i;
                    break;
                }
                node = node.Next;
            }
            return index;
        }
        public void Print()
        {
            if (count == 0)
                throw new InvalidOperationException();
            DoublyNode<T> node = head;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }
            Console.WriteLine();
        }
        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            MyDeque<int> deq = new();
            deq.AddFirst(1);
            deq.AddLast(2);
            deq.AddLast(3);
            deq.Print();
            deq.DeleteFirst();
            deq.DeleteLast();
            deq.Print();
            deq.AddFirst(0);
            deq.AddLast(5);
            deq.AddLast(6);
            deq.Print();
            deq.Delete(2);
            deq.Print();
            deq.Delete(0);
            deq.Print();
            deq.Delete(6);
            deq.Print();
            Console.WriteLine(deq.Find(5));
            Console.WriteLine(deq.Find(7));
        }
    }
}
