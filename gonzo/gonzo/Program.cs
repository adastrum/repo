using System;
using System.Collections.Generic;
using System.Linq;
using gonzo.Algorithms;

namespace gonzo
{
    class Program
    {
        private const int ArrayLength = 10;
        private const int ArrayMinValue = 0;
        private const int ArrayMaxValue = 100;

        private static int[] GetArray(int arrayLength)
        {
            var array = new int[ArrayLength];
            var random = new Random();
            for (var i = 0; i < array.Length; i++)
            {
                var value = random.Next(ArrayMinValue, ArrayMaxValue);
                array[i] = value;
            }
            return array;
        }

        private static void PrintArray(int[] array)
        {
            foreach (var i in array)
            {
                Console.Write("{0,4:D}", i);
            }
        }

        static void Main()
        {
            SortDemo();
            Console.ReadLine();
        }

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

        public static void BinarySearchDemo()
        {
            var array = GetArray(ArrayLength);
            var value = array.Last();
            Array.Sort(array);
            PrintArray(array);
            Console.WriteLine();
            Console.WriteLine("value={0}, index0={1}", value, SearchHelper.BinarySearch(array, value));
        }

        public static void GraphDemo()
        {
            var edges = new[] { new[] { 1, 2 }, new[] { 3, 4 }, new[] { 5 }, new int[] { }, new int[] { }, new int[] { } };
            Console.WriteLine("DepthFirstSearch");
            GraphHelper.DepthFirstSearch(edges, 0);
            Console.WriteLine("DepthFirstSearchNoRecursion");
            GraphHelper.DepthFirstSearchNoRecursion(edges, 0);
            Console.WriteLine("BreadthFirstSearch");
            GraphHelper.BreadthFirstSearch(edges, 0);
        }

        public static void SortDemo()
        {
            var array = GetArray(ArrayLength);
            Console.WriteLine("before sort");
            PrintArray(array);
            //SortHelper.BubbleSort(array);
            //SortHelper.QuickSort(array, 0, ArrayLength - 1);
            SortHelper.InsertSort(array);
            Console.WriteLine();
            Console.WriteLine("after sort");
            PrintArray(array);
        }
    }
}
