using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LR_3DS
{
    public class Deicstra
    {
        private int[,] adjancecyMatrix;
        private bool[] visitedMatrix;
        private int[] matrixMinValues;
        private string[] peaks;

        public Deicstra(int[,] matrix)
        {
            adjancecyMatrix = matrix;
            visitedMatrix = new bool[matrix.GetLength(0)];
            matrixMinValues = new int[matrix.GetLength(0)];
            peaks = new string[matrix.GetLength(0)];
        }

        public void GetOptimalWays(int numberOfElement)
        {

            for (int i = 0; i < adjancecyMatrix.GetLength(0); i++)
            {
                matrixMinValues[i] = adjancecyMatrix[numberOfElement, i];
                peaks[i] += " " + numberOfElement + " ";
                visitedMatrix[i] = false;
            }

            matrixMinValues[numberOfElement] = 0;
            int index = 0, u = 0;

            for (int i = 0; i < adjancecyMatrix.GetLength(0); i++)
            {
                int min = int.MaxValue;

                for (int j = 0; j < adjancecyMatrix.GetLength(0); j++)
                {
                    if (!visitedMatrix[j] && matrixMinValues[j] < min)
                    {
                        min = matrixMinValues[j];
                        index = j;
                    }
                }
                u = index;
                visitedMatrix[u] = true;
                for (int j = 0; j < adjancecyMatrix.GetLength(0); j++)
                {
                    if (!visitedMatrix[j] && adjancecyMatrix[u, j] != int.MaxValue && matrixMinValues[u] != int.MaxValue && ((matrixMinValues[u] + adjancecyMatrix[u, j]) < matrixMinValues[j]))
                    {
                        matrixMinValues[j] = matrixMinValues[u] + adjancecyMatrix[u, j];
                        peaks[j] += " " + u;
                    }
                }
            }

            Print(numberOfElement);
        }

        private void Print(int numberOfElement)
        {
            Console.WriteLine("Стоимость пути из начальной вершины до остальных(Алгоритм Дейкстры):\t\n");
            for (int i = 0; i < adjancecyMatrix.GetLength(0); i++)
            {
                if (matrixMinValues[i] != int.MaxValue)
                    Console.WriteLine(numberOfElement + " -> " + i + " = " + matrixMinValues[i] + " Peaks: " + peaks[i] + " " + i);
                else
                    Console.WriteLine(numberOfElement + " -> " + i + " = " + "маршрут недоступен");
            }
        }
    }

    class Program
    {
        static int[,] Input(int peaks)
        {
            int[,] matrix = new int[peaks, peaks];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            return matrix;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество вершин!");
            int countPeaks = int.Parse(Console.ReadLine());
            int[,] matrix = Input(countPeaks);

            Deicstra deicstra = new Deicstra(matrix);
            
            deicstra.GetOptimalWays(0);

            Console.ReadKey();
        }
    }

}
