/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double[] Input (string s){
    double[] a = {0, 0, 0};
    Console.Write($"Введите три координаты точки {s} через пробел: ");
    string[] s1 = Console.ReadLine().Split(' ');
    if(s1.Length == 3){
        a[0] = Convert.ToDouble(s1[0]);
        a[1] = Convert.ToDouble(s1[1]);
        a[2] = Convert.ToDouble(s1[2]);
    }
    return a;
}
double[] a = Input("A");
double[] b = Input("B");
double distance = Math.Sqrt(Math.Pow(a[0]-b[0], 2) + Math.Pow(a[1]-b[1], 2) + Math.Pow(a[2]-b[2], 2) );
Console.WriteLine($"Расстояние между точками A({a[0]},{a[1]},{a[2]}) и B({b[0]},{b[1]},{b[2]}) = {distance}"); 
