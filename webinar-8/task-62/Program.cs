/* Задача 62. * Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int n = 7;
int [,] arr = new int [n, n];
FillArray(arr);
PrintArray(arr);


// Заполнить спирально
void FillArray(int[,] arr){
    int n1 = arr.GetLength(0);
    int n = n1; // Оставшаяся ширина/высота.
    int i = 0, j = 0;
    int x = 1; // Очередной элемент.
    do{
        int k = 0;
        do { 
            Console.WriteLine($"1: {i}, {j}, {k}, {n}, {x}");
            arr[i,j] = x;  
            k++; j++; x++; // вправо
        } while (k < n-1); 
        ///// Для цикла FOR ошибка - для нечётных n последний в центре остаётся 0. //for (k=0; k<n-1; k++) arr[i, j++] = x++;  // вправо
        for (k = 0; k < n - 1; k++) arr[i++, j] = x++;   // вниз
        for (k = 0; k < n - 1; k++) arr[i, j--] = x++;   // влево
        for (k = 0; k < n - 1; k++) arr[i--, j] = x++;   // вверх
        i++; j++; n -= 2;
        if (n < 0) n = 0;
        Console.WriteLine($"2: {i}, {j}, {k}, {n}, {x}");
    } while (x <= n1*n1);
}


// Вывод
void PrintArray(int[,] array, string msg=""){
    Console.WriteLine(msg);
    for (int i = 0; i < array.GetLength(0); i++)    {
        for (int j = 0; j < array.GetLength(1); j++)        {
            Console.Write($"{array[i, j]:d2} ");
        }
        Console.WriteLine();
    }
}
