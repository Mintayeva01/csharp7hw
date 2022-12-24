// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
Console.WriteLine("Введите число: ");
int entered_number = Convert.ToInt32(Console.ReadLine());
bool found = false;
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (entered_number == matrix [i, j])
                {
                    Console.WriteLine("число найдено");
                    found = true;
                };
        }
    }
if (found == false)
{
    Console.WriteLine("число не найдено");
}

