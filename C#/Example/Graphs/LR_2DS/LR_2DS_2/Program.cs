using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_2DS_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность матрицы смежности\nn = ");
            int n = int.Parse(Console.ReadLine());
            int[,] a = InputR(n);
            //int[,] a = new int[,]
            //{
            //    {0,1,1,0,0,0,0},
            //    {1,0,0,1,1,0,0},
            //    {1,0,0,0,0,1,1},
            //    {0,1,0,0,0,0,0},
            //    {0,1,0,0,0,0,0},
            //    {0,0,1,0,0,0,0},
            //    {0,0,1,0,0,0,0}
            //};
            Output(a);
            BFS(a);
            Console.ReadKey();
        }


        static int[,] InputR(int n)
        {
            int[,] a = new int[n, n];
            Console.WriteLine("Введите значения матрицы смежности: ");
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                {
                    Console.Write("[" + i + "]" + "[" + j + "]" + ": ");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            return a;
        }


        static void Output(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++, Console.WriteLine())
                for (int j = 0; j < a.GetLength(1); j++)
                    Console.Write(" " + a[i, j]);
        }

        static void BFS(int[,] a)
        {
            Queue<int> queue = new Queue<int>();

            bool[] visited = new bool[Convert.ToInt32(Math.Sqrt(a.Length))];

            int V = 0;

            queue.Enqueue(V);

            while (queue.Count > 0)
            {
                V = queue.Dequeue();

                visited[V] = true;

                Console.WriteLine("Вершина: {0}", V+1);
                for (int i = 0; i < Convert.ToInt32(Math.Sqrt(a.Length)); ++i)
                {
                    if ((a[V, i] == 1) && (!visited[i]))
                    {
                        if (!queue.Contains(i)) queue.Enqueue(i);
                    }
    
                }
            }
        }
    }
}
