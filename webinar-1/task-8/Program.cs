/*
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Введите целое число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (i < N){
    i++;
    if(i % 2 == 0){
        Console.Write($"{i}, "); 
    }
}
