// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
//двумерного массива. (можно использовать готовую функцию)
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2
Console.WriteLine("Введите размер массива m и n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int [,] array2d = new int[m, n];
int [,] array2d2 = new int[m, n];
int [] arr = new int [n];
Random random = new Random();
for (int i=0; i<m;i++)
{
    for (int j=0; j<n; j++)
    {
        array2d[i,j]=random.Next (-10,10);
        Console.Write(array2d[i,j]+" ");
        arr[j]=array2d[i,j];
    }
    Console.WriteLine();
    Array.Sort(arr);Array.Reverse(arr);
    for (int j = 0; j <arr.Length; j++)
    {
        array2d2[i,j]=arr[j];
    }
} 
Console.WriteLine();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array2d2[i,j]+" ");    
    }
    Console.WriteLine();
}