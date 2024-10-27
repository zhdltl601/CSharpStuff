using System;
using System.Collections.Generic;

namespace DataStructure
{
    namespace DataStructure
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
            private readonly int vert; // 정점의 수
            private readonly List<int>[] adj; // 인접 리스트
            private readonly bool[] visited;
            private readonly Queue<int> queue = new();

            public Graph(int vertexSize)
            {
                vert = vertexSize;
                adj = new List<int>[vertexSize];
                visited = new bool[vertexSize];
                for (int i = 0; i < vertexSize; i++)
                {
                    adj[i] = new List<int>();
                }
            }
            public void AddEdge(int index, int value)
            {
                adj[index].Add(value);
            }
            public void DFS(int v)
            {
                visited[v] = true;
                Console.Write(v + " ");

                foreach (var neighbor in adj[v])
                {
                    if (!visited[neighbor])
                    {
                        DFS(neighbor);
                    }
                }
            }
            public void BFS(int start)
            {
                bool[] visited = new bool[vert];
                queue.Clear();

                visited[start] = true;
                queue.Enqueue(start);

                while (queue.Count > 0)
                {
                    int v = queue.Dequeue();
                    Console.Write(v + " ");

                    foreach (var neighbor in adj[v])
                    {
                        if (!visited[neighbor])
                        {
                            visited[neighbor] = true;
                            queue.Enqueue(neighbor);
                        }
                    }
                }
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

    }
    public class Program
    {
        public static void Main()
        {
            DataStructure.Graph g = new(5);
            g.AddEdge(0, 1);
            g.AddEdge(0, 3);
            g.AddEdge(1, 2);
            g.AddEdge(1, 3);
            g.AddEdge(2, 3);

            Console.WriteLine("DFS 탐색 결과:");
            g.DFS(0);

            Console.WriteLine("\nBFS 탐색 결과:");
            g.BFS(0);
        }
    }
}
