using System;
using System.Collections.Generic;

namespace gonzo
{
    class Program
    {
        static void Main()
        {
            LinkedListDemo();
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
    }
}
