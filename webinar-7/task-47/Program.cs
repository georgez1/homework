﻿/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

void RandomArray2(int m, int n, double[,] arr) {
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            arr[i, j] = Convert.ToDouble(new Random().Next(-10000, 10000) / 100.0);
        }
    }
}

void PrintArray2(double[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }    
}

Console.Write("Число строк m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Число столбцов n = ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] arr = new double[m, n];
RandomArray2(m, n, arr);
PrintArray2(arr);
