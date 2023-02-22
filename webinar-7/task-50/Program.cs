/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
[1,7] -> по такому индексу нет элемента.
*/

Console.Write("Число строк m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Число столбцов n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[m, n];
RandomArray2(m, n, arr);
PrintArray2(arr);

Console.WriteLine("введите номер строки (считая с нуля) = ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца (считая с нуля) = ");
int n1 = Convert.ToInt32(Console.ReadLine());
if (m1 >= 0 && m1 < arr.GetLength(0) && n1 >= 0 && n1 < arr.GetLength(1)){
    Console.WriteLine($"В строке {m1} и cтолбце {n1} находится элемент {arr[m1,n1]}");
}else{
    Console.WriteLine("Нет такого элемента!");    
}


void RandomArray2(int m, int n, int[,] arr) {
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            arr[i, j] = Convert.ToInt32(new Random().Next(-10, 10));
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
