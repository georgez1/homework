/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Write("M = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("N = ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = RangeSum(M, N);
Console.Write($"{sum}");


int RangeSum(int m, int n){
    if (m == n) return m;
    else return m + RangeSum(m+1, n);
}
