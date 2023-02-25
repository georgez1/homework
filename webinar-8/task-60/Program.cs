/* Задача 60. *...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] arr = new int[2, 2, 2];
Random3D(arr);
Print3D(arr);

// Вывод массива с индексами
void Print3D(int[,,] arr){
    for (int i=0; i<arr.GetLength(0); i++) {
        for (int j=0; j<arr.GetLength(1); j++) {
            Console.WriteLine();
            for (int k=0; k<arr.GetLength(2); k++) {
                Console.Write($"{arr[j,k,i]}({j},{k},{i})  ");
            }
        }
    }
}

// Заполнение массива 3D неповторяющимися двузначными числами
void Random3D(int[,,] arr){
    int n1 = arr.GetLength(0);
    int n2 = arr.GetLength(1);
    int n3 = arr.GetLength(2);
    int a;
    int m = 0; // Сколько чисел уже сгенерировано.
    int[] numbers = new int[n1*n2*n3]; // Массив использованных чисел.
    for (int i=0; i<n1; i++) {
        for (int j=0; j<n2; j++) {
            for (int k=0; k<n2; k++) {
                do{
                    a = new Random().Next(10, 100);
                }while(System.Array.IndexOf(numbers, a) >= 0);
                arr[i, j, k] = a;
                numbers[m] = a;
                m++;
            }
        }
    }
}