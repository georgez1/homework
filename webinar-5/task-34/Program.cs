/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.Write("Введите длину массива:  ");
int len = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[len];
RandonNumbers(numbers);
Console.Write("В массиве ");
PrintArray(numbers);
int count = 0; // Число чётных чисел
for (int i = 0; i < numbers.Length; i++){
    if (numbers[i] % 2 == 0)
    count++;
}
Console.WriteLine($"имеется {numbers.Length} элементов, из них четных: {count}");

void RandonNumbers(int[] numbers){
    for(int i = 0; i < len; i++)    {
        numbers[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] numbers){
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)    {
        Console.Write(numbers[i] + ", ");
    }
    Console.WriteLine("]");
}
