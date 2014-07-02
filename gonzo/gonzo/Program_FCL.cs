using System;
using System.Collections.Generic;
using System.Text;

namespace gonzo
{
    partial class Program
    {
        public static void LinkedListDemo()
        {
            var linkedList = new LinkedList<int>();
            var node = linkedList.AddFirst(1);
            linkedList.AddBefore(node, 0);
            linkedList.AddAfter(node, 2);
            foreach (var i in linkedList)
            {
                Console.WriteLine(i);
            }
        }

        public static void StackDemo()
        {

            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            foreach (var i in stack)
            {
                Console.Write("{0}\t", i);
            }
            Console.WriteLine();
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
        }

        public static void QueueDemo()
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            foreach (var i in queue)
            {
                Console.Write("{0}\t", i);
            }
            Console.WriteLine();
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
        }

        public static void StringBuilderDemo()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("date: {0}", DateTime.Today.ToShortDateString());
            sb.AppendLine();
            sb.AppendFormat("time: {0}", DateTime.Now.ToShortTimeString());
            Console.WriteLine(sb.ToString());
        }
    }
}
