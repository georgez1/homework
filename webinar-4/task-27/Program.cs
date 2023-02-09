/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int number = ReadInt("Введите число: ");
int digits = Digits(number);
int sum = SumDigits(number, digits);
Console.WriteLine(sum);

// Ввод данных
int ReadInt(string message){
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Кол-во цифр в числе
int Digits(int a){
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

// Cумма цифр в числе
int SumDigits(int n, int digits){
    int sum = 0;
    for (int i = 1; i <= digits; i++) {
        sum += n % 10;
        n /= 10;
    }
    return sum;
}
