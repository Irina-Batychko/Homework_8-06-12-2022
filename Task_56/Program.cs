/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка  */

int rows = 4;
int columns = 4;
int[,] array = new int[rows, columns];
FillArrayRandomNumbers(array);
PrintArray(array);

int sumRow = 0;
int rowIndex = 0;

for (int j = 0; j < array.GetLength(1); j++)
{
    sumRow += array[0, j];
}
for (int i = 0; i < array.GetLength(0); i++)
{
    int tempSum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        tempSum += array[i, j];
    }
    if (tempSum < sumRow)
    {
        sumRow = tempSum;
        rowIndex = i;
    }
}
Console.WriteLine($"{rowIndex + 1} строка с наименьшей суммой элементов!");

void PrintArray(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            Console.Write($"{image[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void FillArrayRandomNumbers(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}