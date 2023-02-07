// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Console.Clear();
Console.Write("задайте размер массива, но не менее 2 строк:");
int m = Convert.ToInt32(Console.ReadLine()); //кол-во срок 1й матрицы
int n = m + 1; // кол-во солбцов 2й матрицы

int minValue = 0;
int maxValue = 5;


int[,] MultiArray(int m, int n, int minValue, int maxValue) // min и max можно задать вручную здесь, или запросить у пользов.
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return (result);
}
int[,] Matrix = MultiArray(m, n, minValue, maxValue);

int h = n; //кол-во строк 2 матрицы
int l = m; //кол-во столбцов 2 матрицы


int[,] MultiArray2(int h, int l, int minValue, int maxValue)
{
    int[,] result = new int[h, l];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return (result);
}
int[,] Matrix2 = MultiArray2(h, l, minValue, maxValue);


int[,] MultiplicationTwoMatrix(int[,] Matrix, int[,] Matrix2)
{
    int[,] result = new int[l, m]; //результа: новая матрица с произвдениями двух заданных

    for (int i = 0; i < Matrix.GetLength(0); i++) //строк первой Матрицы
    {
        for (int j = 0; j < Matrix2.GetLength(1); j++) // столбец второй Матрицы
        {
            for (int k = 0; k < Matrix.GetLength(1); k++) // столбец первой матрицы
            {
                result[i, j] += Matrix[i, k] * Matrix2[k, j];
            }
        }
    }
    return (result);
}
int[,] Multiplication = MultiplicationTwoMatrix(Matrix, Matrix2);


void PrintMultyArray(int[,] mArray)
{
    for (int i = 0; i < mArray.GetLength(0); i++)
    {
        for (int j = 0; j < mArray.GetLength(1); j++)
        {
            Console.Write($"{mArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.ForegroundColor = ConsoleColor.Yellow;
PrintMultyArray(Matrix);
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
PrintMultyArray(Matrix2);
Console.ResetColor();
Console.WriteLine();
PrintMultyArray(Multiplication);
 