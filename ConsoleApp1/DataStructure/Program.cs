using System;
using System.Collections.Generic;
using DataStructure.MyDataStructure;
using DataStructure.Searching;
namespace DataStructure
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
        public class Graph<T> where T : struct
        {
            private readonly T[,] adj; // 인접 리스트
            public readonly int vertexSize;
            public int GetVertexSize => vertexSize;
            public T[,] GetAdjust => adj;
            public Graph(int vertexSize)
            {
                this.vertexSize = vertexSize;
                adj = new T[vertexSize, vertexSize];
            }
            public void SetVertexDirection(int index, int index2, T value)
            {
                adj[index, index2] = value;
            }
            public void SetEdge(int index, int index2, T weight = default)
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
            public static void DFS<T>(Graph<T> graph) where T : struct
            {
                //bool[] visited = new bool[graphVertexCount];
            }
            public static void BFS<T>(Graph<T> graph, int startIndex) where T : struct
            {
                int graphVertexCount = graph.GetVertexSize;
                T[,] adj = graph.GetAdjust;
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
                        if (!visited[i] && !EqualityComparer<T>.Default.Equals(adj[current, i], default(T)))
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
            Graph<int> g = new(n);
            for (int i = 0; i < m; i++)
            {
                int a, b, weight;
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                weight = 1;// int.Parse(Console.ReadLine());
                g.SetEdge(a, b, weight);
            }
            MySearch.BFS(g, 0);
        }
    }
}
