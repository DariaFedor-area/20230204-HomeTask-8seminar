// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
 с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Clear();
Console.Write("задайте размер для прямоугольного массива:");
int m = Convert.ToInt32(Console.ReadLine()); //кол-во срок
int n = m + 2; // кол-во солбцов

// int m = 10;
// int n = m;

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
PrintMultyArray(Matrix);

void CountSumsOfElementsInRow(int[,] mArray)
{
    int min = 0;
    int row = 1;
    for (int i = 0; i < mArray.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < mArray.GetLength(1); j++)
        {
            summ += mArray[i, j];
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"Сумма {i + 1} строки = {summ};\n");
        Console.ResetColor();
        
        if (min == 0) min = summ;
        else if (min > summ)
        {
            min = summ;
            row = i + 1;
        }
    }
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Наименьшая сумма в {row}-й строке");
    Console.ResetColor();
}
CountSumsOfElementsInRow(Matrix);


