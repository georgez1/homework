/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] A = new int[2, 2]; 
RandomArray(A);
int[,] B = new int[2, 2]; 
RandomArray(B);
PrintArray(A, "A = ");
PrintArray(B, "B = ");
int[,] C = new int[2, 2]; 
if ( MulMatr(A, B, C) ) 
    PrintArray(C, "A*B = ");
else 
    Console.WriteLine("Неверные размеры матриц!");


// Заполнить случайными числами
void RandomArray(int[,] array){
    for (int i=0; i<array.GetLength(0); i++)    {
        for (int j=0; j<array.GetLength(1); j++)        {
            array[i,j] = new Random().Next(1, 10);
        }
    }
}

// Вывод
void PrintArray(int[,] array, string msg=""){
    Console.WriteLine(msg);
    for (int i = 0; i < array.GetLength(0); i++)    {
        for (int j = 0; j < array.GetLength(1); j++)        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

 bool MulMatr(int[,] A, int[,] B, int[,] C){
    if (A.GetLength(0) != B.GetLength(1))         
        return false;
    for (int i=0; i<A.GetLength(0); i++) {
        for (int j=0; j<B.GetLength(1); j++) {
            C[i, j] = 0;
            for (int k=0; k<A.GetLength(1); k++) {
                C[i,j] += A[i,k] * B[k,j];
            }
        }
    }
    return true;
}
