using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deikstri
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Введите размерность матрицы смежности n = ");

            Console.WriteLine("Введите стартовую вершину: ");
            //int n = int.Parse(Console.ReadLine());
            int start = int.Parse(Console.ReadLine()) - 1;
            //int[,] a = InputS(n);
            Console.WriteLine("Матрица смежности: ");
            int[,] a = new int[,]
            {
                {0,5,7,8,0,0,0,0,0,0,0},
                {0,0,4,0,3,7,0,0,0,0,0},
                {0,0,0,0,0,4,0,0,0,0,0},
                {0,0,8,0,0,0,7,0,0,0,0},
                {0,0,0,0,0,0,0,3,12,0,0},
                {0,0,0,0,0,0,3,5,10,0,0},
                {0,0,0,0,0,0,0,0,0,12,0},
                {0,0,0,0,0,0,0,0,0,0,18},
                {0,0,0,0,0,0,0,0,0,0,10},
                {0,0,0,0,0,0,0,0,0,0,9},
                {0,0,0,0,0,0,0,0,0,0,0}
            };
            Output(a);
            AFB(a, start);
            Console.ReadKey();
        }


        static int[,] InputS(int n)
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

        static void AFB(int[,] mas, int start)
        {
            int INF = 10000000;

            int[] dist = new int[mas.GetLength(0)];

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                dist[i] = INF;
            }

            dist[start] = 0;
            for (int k = 0; k < mas.GetLength(0) - 1; k++)
            {
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    for (int j = 0; j < mas.GetLength(1); j++)
                    {
                        if (mas[i, j] > 0)
                        {
                            if ((dist[i] + mas[i, j]) < dist[j]) dist[j] = mas[i, j] + dist[i];
                        }
                    }
                }
            }
            Console.WriteLine("From " + (start + 1) + " to: ");
            for (int i = 0; i < dist.Length; i++)
            {
                Console.WriteLine("[" + (i + 1) + "]" + " " + dist[i]);
            }
        }
    }
}
