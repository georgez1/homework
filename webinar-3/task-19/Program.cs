/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Write("Введите пятизначное число: ");
int x = Convert.ToInt32(Console.ReadLine());
if(x < 10000 || x > 99999){
    Console.WriteLine("Неверное число!");
}else{
    string s = Convert.ToString(x);
    int n = s.Length-1;
    int k = 0;
    bool result = true;
    while(k < n){
        if(s[k] != s[n]){
            Console.WriteLine("Не палиндром");
            result = false;
            break;
        }else{
            k++;
            n--;
        }
    }
    if(result) Console.WriteLine("Палиндром");
}
