/*  Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int[] array = InputData();
int m = Calculate(array);
System.Console.WriteLine($"Число элементов больше 0 равно {m}");

int[] InputData(){
    System.Console.Write("Введите кол-во элементов: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] a = new int[n];
    for(int i=0; i < n; i++){
        System.Console.Write($"A[{i}] = ");
        a[i] = Convert.ToInt32(Console.ReadLine());
    }
    return a;
}

int Calculate(int[] a){
    int m = 0;
    for(int i=0; i < a.Length; i++){
        if(a[i] > 0) m++;
    }
    return m;
}
