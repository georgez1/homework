/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int A = ReadInt1("Введите число A : ");
int B = ReadInt1("Введите число B : ");
int C = Pow(A, B);
Console.WriteLine($"{A}^{B} = {C}");

// Возведение `a` в степень `b`
int Pow(int a, int b){
    int result = 1;
    for (int i = 1; i <= b; i++) {
        result = result * a;
    }
    return result;
}

// Ввод целого числа
int ReadInt1(string message){
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

