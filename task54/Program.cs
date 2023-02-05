// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

/* СЕМИНАР_8:
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

Console.Clear();
Console.WriteLine("задайте параметры массива:");
Console.Write("высота(количество строк):");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("ширина(количество столбцов): ");
int n = Convert.ToInt32(Console.ReadLine());

int minValue = 0;
int maxValue = 10;

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


void SortFromMaxToMin(int[,] mArray)
{
    int temp = 0;
    for (int i = 0; i < mArray.GetLength(0); i++)
    {
        for (int j = 0; j < mArray.GetLength(1); j++)
        {
            for (int l = j + 1; l < mArray.GetLength(1); l++)
            {
                if (mArray[i, l] > mArray[i, j])
                {
                    temp = mArray[i, j];
                    mArray[i, j] = mArray[i, l];
                    mArray[i, l] = temp;
                }
            }
        } 
        //Console.WriteLine();
    }
}
PrintMultyArray(Matrix);
SortFromMaxToMin(Matrix);
Console.ForegroundColor = ConsoleColor.Green;
PrintMultyArray(Matrix);
Console.ResetColor();


