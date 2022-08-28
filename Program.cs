// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] GetArray( int m, int n)
// {
//     int[,] matrix = new int[m,n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(11);
//         }
//     }
//     return matrix;
// }
// int[,] resultMatrix = GetArray(rows, columns);
// PrintArray(resultMatrix);
// void PrintArray(int[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
//         for (int m = 0; m < inputMatrix.GetLength(1); m++)
//         {
//             Console.Write(inputMatrix[i,m] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] GetArray( int m, int n)
// {
//     int[,] matrix = new int[m,n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = i+j;
//         }
//     }
//     return matrix;
// }
// int[,] resultMatrix = GetArray(rows, columns);
// PrintArray(resultMatrix);
// void PrintArray(int[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
//         for (int m = 0; m < inputMatrix.GetLength(1); m++)
//         {
//             Console.Write(inputMatrix[i,m] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] GetArray( int m, int n)
// {
//     int[,] matrix = new int[m,n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(31);
//         }
//     }
//     return matrix;
// }
// int[,] resultMatrix = GetArray(rows, columns);
// PrintArray(resultMatrix);
// void PrintArray(int[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
//         for (int m = 0; m < inputMatrix.GetLength(1); m++)
//         {
//             Console.Write(inputMatrix[i,m] + "\t");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] ReplaceBySquare(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i%2 == 0 && j%2 == 0) matrix[i,j] = Convert.ToInt32(Math.Pow(matrix[i,j], 2));
//         }
//     }
//     return matrix;
// }
// ReplaceBySquare(resultMatrix);
// Console.WriteLine();
// PrintArray(resultMatrix);

// Задача 51. Найти сумму элементов главной диагонали.
// например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] GetArray( int m, int n)
// {
//     int[,] matrix = new int[m,n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(11);
//         }
//     }
//     return matrix;
// }
// int[,] resultMatrix = GetArray(rows, columns);
// PrintArray(resultMatrix);
// void PrintArray(int[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
//         for (int m = 0; m < inputMatrix.GetLength(1); m++)
//         {
//             Console.Write(inputMatrix[i,m] + "\t");
//         }
//         Console.WriteLine();
//     }
// }
// int summ = 0;
// for (int i = 0; i < resultMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < resultMatrix.GetLength(1); j++)
//         {
//             if (i == j) summ += resultMatrix[i,j] ;
//         }
//     }
// Console.WriteLine(" Сумма элементов главной диагонали равна " + summ);

// int a = 13;

// void ToBin(int n)
// {
//     if(n==0)
//     {
//         return;
//     }
    
//     ToBin(n/2);
//     Console.Write(n%2);
// }
// ToBin(a);

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] GetArray( int m, int n)
{
    double[,] matrix = new double[m,n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = (new Random().NextDouble())*100;
        }
    }
    return matrix;
}
double[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);
void PrintArray(double[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++)
        {
            Console.Write(Math.Round(inputMatrix[i,m], 1) + "\t");
        }
        Console.WriteLine();
    }
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите индекс строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] GetArray( int m, int n)
{
    int[,] matrix = new int[m,n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(11);
        }
    }
    return matrix;
}
int[,] resultMatrix = GetArray(4, 4);
PrintArray(resultMatrix);
void PrintArray(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++)
        {
            Console.Write(inputMatrix[i,m] + "\t");
        }
        Console.WriteLine();
    }
}
if ( row < resultMatrix.GetLength(0) && column < resultMatrix.GetLength(1)) Console.WriteLine("Искомый элемент: " + resultMatrix[row, column]);
else Console.WriteLine("В массиве нет элемента с таким индексом");

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] GetArray( int m, int n)
{
    int[,] matrix = new int[m,n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(11);
        }
    }
    return matrix;
}
int[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);
void PrintArray(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++)
        {
            Console.Write(inputMatrix[i,m] + "\t");
        }
        Console.WriteLine();
    }
}
for (int k = 0; k < columns; k++)
{
    int summ = 0;
    for (int m = 0; m < rows; m++)
    {
        summ = summ + resultMatrix[m,k];
    }
    Console.WriteLine("Среднее арифметическое стобца с индексом " + k + " равно " + Convert.ToDouble(summ)/rows);
}
