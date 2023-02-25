/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] array = new int[3, 4];
RandomArray(array);
PrintArray(array);
SortDown(array);
Console.WriteLine();
PrintArray(array);

// Заполнить случайными числами
void RandomArray(int[,] array){
    for (int i=0; i<array.GetLength(0); i++)    {
        for (int j=0; j<array.GetLength(1); j++)        {
            array[i,j] = new Random().Next(1, 10);
        }
    }
}

// Сортировка по убыванию элементов строки 
void SortDown(int[,] array){
    int n = array.GetLength(0);
    int m = array.GetLength(1);
    for (int i=0; i<n; i++)  {
        for (int j = 0; j<m; j++) {
            for (int k=0; k<m-1; k++) {
                if (array[i,k] < array[i,k+1]) {
                    // поменять местами:
                    int temp = array[i,k+1];
                    array[i,k+1] = array[i,k];
                    array[i,k] = temp;
                }
            }
        }
    }
}

// Вывод
void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)    {
        for (int j = 0; j < array.GetLength(1); j++)        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
