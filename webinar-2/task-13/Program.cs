/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите целое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write($"Вы ввесли число {x} = ");
int d; // очередная цифра
string s = ""; // строка - цифры со старшей
while(x > 0) {
     d = x % 10;
     x = x / 10;
     s = Convert.ToString(d) + s;
     // Console.WriteLine($"{s}");
}
int n = s.Length; // кол-во цифр
Console.Write(s);
if (n >= 3){
    Console.WriteLine($", третья цифра: {s[2]}.");
}else{
    Console.WriteLine($", третьей цифры нет.");
}
