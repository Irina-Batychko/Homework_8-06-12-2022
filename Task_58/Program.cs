/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18  */

Console.Write("Введите количество строк: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns1 = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = new int[rows1, columns1];
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        matrix1[i, j] = new Random().Next(0, 10);
        Console.Write(matrix1[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.Write("Введите количество строк: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns2 = Convert.ToInt32(Console.ReadLine());
int[,] matrix2 = new int[rows2, columns2];

for (int i = 0; i < matrix2.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        matrix2[i, j] = new Random().Next(0, 10);
        Console.Write(matrix2[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int[,] compositionMatrix = new int[rows2, columns1];
Console.WriteLine("Результирующая матрица");
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        for (int y = 0; y < matrix1.GetLength(1); y++)
        {
            compositionMatrix[i, j] = compositionMatrix[i, j] + matrix1[i, y] * matrix2[y, j];
        }
       
        Console.Write(compositionMatrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();