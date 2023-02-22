/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Write("Кол-во строк m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Кол-во столбцов n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[m, n];
RandomArray2(m, n, arr);
PrintArray2(arr);
Console.WriteLine("--------------------------");
for (int j = 0; j < arr.GetLength(1); j++){
    double avrg = 0;
    for (int i = 0; i < arr.GetLength(0); i++)    {
        avrg += arr[i, j];
    }
    avrg /= m;
    Console.Write($"{avrg}\t");
}
Console.WriteLine();


void RandomArray2(int m, int n, int[,] arr) {
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            arr[i, j] = Convert.ToInt32(new Random().Next(0, 10));
        }
    }
}

void PrintArray2(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }    
}
