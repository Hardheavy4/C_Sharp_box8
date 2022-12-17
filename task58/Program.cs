// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

Console.WriteLine("Введите размер матрицы 1: ");
int [,] array2d = new int[Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine())];
Random random = new Random();
for (int i=0; i<array2d.GetLength(0);i++)
    {
        for (int j=0; j<array2d.GetLength(1); j++)
        {
            array2d[i,j]=random.Next (0,10);
            Console.Write(array2d[i,j]+" ");
        }
        Console.WriteLine();
    }
Console.WriteLine();
Console.WriteLine("Введите размер матрицы 2: ");
int [,] array2d2 = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
for (int i=0; i<array2d2.GetLength(0);i++)
    {
        for (int j=0; j<array2d2.GetLength(1); j++)
        {
            array2d2[i,j]=random.Next (0,10);
            Console.Write(array2d2[i,j]+" ");
        }
        Console.WriteLine();
    }
Console.WriteLine();
if (array2d.GetLength(1) != array2d2.GetLength(0))
{
    Console.WriteLine("Матрицы не соразмерны");
    Environment.Exit(0);
}
int [,] array2d2new = new int[array2d.GetLength(0),array2d2.GetLength(1)];
for (int i = 0; i < array2d.GetLength(0); i++)
{
    for (int j = 0; j < array2d2.GetLength(1); j++)
    {
        for (int k = 0; k < array2d2.GetLength(0); k++)
        {
            array2d2new[i,j] += array2d[i,k] * array2d2[k,j];
        }
    }
}
for (int i = 0; i < array2d2new.GetLength(0); i++)
{
    for (int j = 0; j < array2d2new.GetLength(1); j++)
    {
        Console.Write(array2d2new[i,j]+" ");
    }Console.WriteLine();
}