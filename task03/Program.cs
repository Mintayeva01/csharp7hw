﻿// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] matrix = new int [3, 4] {
                {1,4,7,2},
                {5,9,2,3},
                {8,4,2,4},
};
void PrintArray(int[,]matrix)
{for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();
    }
}
PrintArray(matrix);
for (int i = 0; i < matrix.GetLength(0); i++)
    {int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           sum += matrix[i,j];
        }
        Console.WriteLine(sum/matrix.GetLength(1));
    }

