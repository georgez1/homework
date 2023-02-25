/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] array = new int[4, 4];
RandomArray(array);
PrintArray(array);
SumRow(array);


// Заполнить случайными числами
void RandomArray(int[,] array){
    for (int i=0; i<array.GetLength(0); i++)    {
        for (int j=0; j<array.GetLength(1); j++)        {
            array[i,j] = new Random().Next(1, 10);
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

// Сумма элементов строки
void SumRow(int[,] array){
    int n = array.GetLength(0);
    int m = array.GetLength(1);
    int srow = 0; // Значение мин суммы
    int irow = 0; // Номер строки с мин суммой
    for (int i=0; i<m; i++) {
        srow += array[0,i];
    }
    for (int i=0; i<n; i++) {
        int sum = 0;
        for (int j=0; j<m; j++) {
            sum += array[i,j];
        }
        Console.WriteLine($"Для строки {i+1} сумма элементов = {sum}");
        if (sum < srow) {
            srow = sum;
            irow = i;
        }
    }
    Console.Write($"Строка (считая с 1) с наименьшей суммой элементов: {irow + 1}");
}
