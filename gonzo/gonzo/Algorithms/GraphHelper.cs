using System;
using System.Collections.Generic;

namespace gonzo.Algorithms
{
    class GraphHelper
    {
        public static void DepthFirstSearch(int[][] edges, int startIndex, bool[] visited = null)
        {
            if (visited == null)
            {
                visited = new bool[edges.Length];
            }
            visited[startIndex] = true;
            Console.WriteLine(startIndex);
            foreach (var edge in edges[startIndex])
            {
                if (!visited[edge])
                {
                    DepthFirstSearch(edges, edge, visited);
                }
            }
        }

        public static void DepthFirstSearchNoRecursion(int[][] edges, int startIndex, bool[] visited = null)
        {
            if (visited == null)
            {
                visited = new bool[edges.Length];
            }
            var stack = new Stack<int>();
            stack.Push(startIndex);
            while (stack.Count > 0)
            {
                var index = stack.Pop();
                visited[index] = true;
                Console.WriteLine(index);
                for (var i = edges[index].Length - 1; i >= 0; i--)
                {
                    var edge = edges[index][i];
                    if (!visited[edge] && !stack.Contains(edge))
                    {
                        stack.Push(edge);
                    }
                }
            }
        }

        public static void BreadthFirstSearch(int[][] edges, int startIndex, bool[] visited = null)
        {
            if (visited == null)
            {
                visited = new bool[edges.Length];
            }
            var queue = new Queue<int>();
            queue.Enqueue(startIndex);
            while (queue.Count > 0)
            {
                var index = queue.Dequeue();
                visited[index] = true;
                Console.WriteLine(index);
                foreach (var edge in edges[index])
                {
                    if (!visited[edge] && !queue.Contains(edge))
                    {
                        queue.Enqueue(edge);
                    }
                }
            }
        }
    }
}
