/* Задача 60. 
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)  */

int rows = ReadInt("Введите количество строк массива(X): ");
int columns = ReadInt("Введите количество столбцов массива(Y): ");
int sheets = ReadInt("Введите количество листов массива(Z): ");
Console.WriteLine();
int[,,] array = new int[rows, columns, sheets];
FillArrayRandomNumbers(array);
WriteArray(array);

void WriteArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}{(i, j, k)} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
void FillArrayRandomNumbers(int[,,] array)
{
    int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    for (int i = 0; i < temp.Length; i++)
    {
        temp[i] = new Random().Next(10, 100);
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                }
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[x, y, z] = temp[count];
                count++;
            }
        }
    }
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}