/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int ArrayLen = ReadInt1("Введите длинну массива : ");
int[] randomArray = new int[ArrayLen];
for (int i = 0; i < randomArray.Length; i++){
    randomArray[i] = new Random().Next(1, 100);
    Console.Write(randomArray[i] + " ");
}

// Ввод данных
int ReadInt1(string message){
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
