/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.Write($"Введите длину массива: ");
int len = Convert.ToInt32(Console.ReadLine()); 
int[] numbers = new int[len];
RandonNumbers(1, 100, numbers);
PrintArray(numbers);
int sum = SumNumbers(numbers);
Console.WriteLine($"Сумма элементов на нечётных позициях: {sum}");

void RandonNumbers(int min, int max, int[] numbers){
    for(int i = 0; i < len; i++)    {
        numbers[i] = new Random().Next(min, max);
    }
}

int SumNumbers(int[] numbers){
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++) {
        if (i % 2 != 0) {
            sum += numbers[i];
        }
    }
    return sum;
}

void PrintArray(int[] numbers){
    Console.Write("Массив: [ ");
    for(int i = 0; i < numbers.Length; i++)    {
        Console.Write(numbers[i] + ", ");
    }
    Console.WriteLine("]");
}
