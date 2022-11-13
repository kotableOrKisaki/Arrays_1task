using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = 3;
            int columnsCount = 4;
            int beginRandomValue = 0;
            int endRandomValue = 10;
            int rowNumber = 2;
            int columnNumber = 1;
            int sumInRow = 0;
            int multiplicationInColumn = 1;
            int[,] array = new int[rowsCount,columnsCount];
            Random radom = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = radom.Next(beginRandomValue, endRandomValue);
                    Console.Write(array[i,j] + "\t");

                    if (i == rowNumber)
                    {
                        sumInRow += array[i, j];
                    }

                    if (j == columnNumber)
                    {
                        multiplicationInColumn *= array[i, j];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Сумма элементов строки с индексом {0} = {1}", rowNumber, sumInRow);
            Console.WriteLine("Произведение элементов столбца с индексом {0} = {1}", columnNumber, multiplicationInColumn);
        }
    }
}
