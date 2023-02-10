/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76

*/

Console.Write("Введите длину массива  ");
int len = Convert.ToInt32(Console.ReadLine());
double[] number = new double[len];
RandomNumbers(number);
PrintArray(number);
double min = Int32.MaxValue;
double max = Int32.MinValue;
for (int i = 0; i < number.Length; i++){
    if (number[i] > max)        {
        max = number[i];
    } 
    if (number[i] < min){
        min = number[i];
    }
}
double range = max - min;
Console.WriteLine($"Всего {number.Length} чисел. Макс = {max}, Мин = {min}");
Console.WriteLine($"Разность между макс и мин = {range}");

void RandomNumbers(double[] number){
    for(int i = 0; i < number.Length; i++){
        number[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
    }
}

void PrintArray(double[] number){
    Console.Write("Массив: [ ");
    for(int i = 0; i < number.Length; i++){
        Console.Write(number[i] + "; ");
    }
    Console.WriteLine("]");
}

