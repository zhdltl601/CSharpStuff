using System;
using System.Collections.Generic;
using Algorithm.MyDataStructure;
using Algorithm.Searching;
using System.Linq;
namespace Algorithm
{
    namespace MyDataStructure
    {
        // -자료구조-
        // 시간복잡도
        // 스택
        public class Stack
        {
        }
        // 큐
        public class Queue
        {
        }
        // circular 큐
        // 연결리스트
        // 레드블랙트리
        // 해쉬테이블
        // 트리
        // 그래프
        public class Graph
        {
            private readonly int[,] adj; // 인접 리스트
            public readonly int vertexSize;
            public int GetVertexSize => vertexSize;
            public int[,] GetAdjust => adj;
            public Graph(int vertexSize)
            {
                this.vertexSize = vertexSize;
                adj = new int[vertexSize, vertexSize];
            }
            public void SetVertexDirection(int index, int index2, int value)
            {
                adj[index, index2] = value;
            }
            public void SetEdge(int index, int index2, int weight = default)
            {
                SetVertexDirection(index, index2, weight);
                SetVertexDirection(index2, index, weight);
            }
        }
    }
    namespace Sorting
    {
        // -정렬-
        // 선택정렬
        // 삽입정렬
        // 버블정렬
        // 계수정렬
        // 기수정렬
        // 퀵정렬
        // 병합정렬
        //

    }
    namespace Searching
    {
        // -탐색-
        // 이진탐색
        // 순차탐색
        // 이분탐색 
        // 매개변수 탐색
        // DFS, BFS
        public class MySearch
        {

        }
        public static class MySearchExtension
        {
            public static int[] Dijkstra(this Graph graph, int m)
            {
                int graphVertexSize = graph.GetVertexSize;
                var adj = graph.GetAdjust;
                int[] dis = new int[m];
                bool[] visited = new bool[m];

                for (int i = 0; i < graphVertexSize - 1; i++)
                {
                    dis[i] = int.MaxValue;
                }
                dis[graphVertexSize - 1] = 0;

                for (int i = 0; i < graphVertexSize; i++)
                {
                    int GetMinIndex()
                    {
                        int min = int.MaxValue;
                        int minIndex = 0;
                        for (int j = 0; j < m; j++)
                        {
                            if (dis[j] < min && visited[j] == false)
                            {
                                min = dis[i];
                                minIndex = j;
                            }
                        }
                        return minIndex;
                    }
                    int minNodeIndex = GetMinIndex();
                    visited[minNodeIndex] = true;

                    for (int j = 0; j < m; j++)
                    {
                        if (visited[j] == false && adj[minNodeIndex, j] != 0)
                        {
                            if (dis[j] > dis[minNodeIndex] + adj[minNodeIndex, j])
                            {
                                dis[j] = dis[minNodeIndex] + adj[minNodeIndex, j];
                            }
                        }
                    }
                }
                return dis;
            }
            public static void DFS(this Graph graph, int startIndex)
            {
                int graphVertexCount = graph.GetVertexSize;
                var adj = graph.GetAdjust;
                bool[] visited = new bool[graphVertexCount];
                void DFSUtil(int current, bool[] visited)
                {
                    visited[current] = true;
                    Console.Write(current + " "); // 현재 노드 출력

                    for (int i = 0; i < graphVertexCount; i++)
                    {
                        if (!visited[i] && !EqualityComparer<int>.Default.Equals(adj[current, i], default(int)))
                        {
                            DFSUtil(i, visited);
                        }
                    }
                }
                Console.WriteLine("DFS Traversal starting from vertex " + startIndex + ":");
                DFSUtil(startIndex, visited);
                Console.WriteLine();
            }
            public static void BFS(this Graph graph, int startIndex) 
            {
                int graphVertexCount = graph.GetVertexSize;
                var adj = graph.GetAdjust;
                bool[] visited = new bool[graphVertexCount];
                System.Collections.Generic.Queue<int> queue = new();

                visited[startIndex] = true;
                queue.Enqueue(startIndex);

                Console.WriteLine("BFS searching..");

                while (queue.Count > 0)
                {
                    int current = queue.Dequeue();
                    Console.Write(current + " ");

                    for (int i = 0; i < graphVertexCount; i++)
                    {
                        if (!visited[i] && !EqualityComparer<int>.Default.Equals(adj[current, i], default(int)))
                        {
                            visited[i] = true;
                            queue.Enqueue(i);
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
    public class Program
    {
        public static void Main()
        {
            int n, m;
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            Graph g = new(n);
            for (int i = 0; i < m; i++)
            {
                int a, b, weight;
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                weight = int.Parse(Console.ReadLine());
                g.SetEdge(a - 1, b - 1, weight);
            }
            var dis = g.Dijkstra(m);
            int answer = 0;
            for (int i = 0; i < n; i++)
            {
                if (answer < dis[i])
                {
                    answer = dis[i];
                }
            }
            Console.WriteLine(answer);
            //g.DFS(0);
            //g.BFS(0);
        }
    }
}
