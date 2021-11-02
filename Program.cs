using System;

namespace Homework_4_Source_Task_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int k;

            int Matrix1rows = 0;
            int Matrix2rows = 0;
            int Matrix1Cols = 0;
            int Matrix2Cols = 0;

            int MinNuber = 0;
            int MaxNuber = 20;

            Console.WriteLine("Программа умножения матриц.");
            Console.WriteLine("Обратите внимание: для корректного выполнения операции:");
            Console.WriteLine("Длинна строк первой матрицы должна равняться длинне столбцов второй матрицы.");

            while (Matrix1rows < 1 || Matrix1rows > 255)
            {
                Console.WriteLine("Введите количество столбцов матрицы 1 от 2 до 255: ");
                Matrix1rows = int.Parse(Console.ReadLine());
            }

            while (Matrix1Cols < 1 || Matrix1Cols > 255)
            {
                Console.WriteLine("Введите количество строк матрицы 1 от 2 до 255: ");
                Matrix1Cols = int.Parse(Console.ReadLine());
            }

            while (Matrix2rows < 1 || Matrix2rows > 255)
            {
                Console.WriteLine("Введите количество столбцов матрицы 2 от 2 до 255: ");
                Matrix2rows = int.Parse(Console.ReadLine());
            }

            while (Matrix2Cols < 1 || Matrix2Cols > 255)
            {
                Console.WriteLine("Введите количество строк матрицы 2 от 2 до 255: ");
                Matrix2Cols = int.Parse(Console.ReadLine());
            }


            int[,] matrix1 = new int[Matrix1rows, Matrix1Cols];
            int[,] matrix2 = new int[Matrix2rows, Matrix2Cols];
            int[,] MultMatrix = new int[Matrix2rows, Matrix1Cols];
            

            //заполнение
            var Rand = new Random();

            Console.WriteLine();
            Console.WriteLine("Исходная матрица 1:");
            Console.WriteLine();

            //матрица 1
            for (i = 0; i < Matrix1rows; i++)
            {
                for (j = 0; j < Matrix1Cols; j++)
                {
                    matrix1[i, j] = Rand.Next(MinNuber, MaxNuber);
                    Console.Write($"{matrix1[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Исходная матрица 2:");
            Console.WriteLine();
            //матрица 2
            for (i = 0; i < Matrix2rows; i++)
            {
                for (j = 0; j < Matrix2Cols; j++)
                {
                    matrix2[i, j] = Rand.Next(MinNuber, MaxNuber);
                    Console.Write($"{matrix2[i, j]} ");
                }
                Console.WriteLine();
            }

            //Умножение
            
            Console.WriteLine();
            Console.WriteLine("Результат:");
            Console.WriteLine();

            for (i = 0; i < Matrix1rows; i++)
            {
                if (matrix1.GetUpperBound(0) + 1 != matrix2.GetUpperBound(1) + 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Умножение не возможно");
                    break;
                }
                for (j = 0; j < Matrix2Cols; j++)
                {
                    MultMatrix[i, j] = 0;
                    for (k = 0; k < Matrix1Cols; k++)
                    {
                        MultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            for (i = 0; i < Matrix1rows; i++)
            {
                if (matrix1.GetUpperBound(0) + 1 != matrix2.GetUpperBound(1) + 1)
                {
                    break;
                }
                for (j = 0; j < Matrix2Cols; j++)
                {
                    Console.Write($"{MultMatrix[i,j]} ");
                }
                
                Console.WriteLine();
            }


            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
