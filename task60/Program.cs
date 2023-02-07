// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/


Console.Clear();
Console.Write("задайте размер трехмерного равностороннего массива: ");
int m = Convert.ToInt32(Console.ReadLine()); //кол-во срок 
int n = m; // кол-во солбцов 
int l = m; // глубина матрицы

int minValue = 10;
int maxValue = 100;


int[,,] CubicArray(int m, int n, int l, int minValue, int maxValue)
{
    int[,,] result = new int[m, n, l];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                result[i, j, k] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return (result);
}
int[,,] CubArray = CubicArray(m, n, l, minValue, maxValue);


void PrintMultyArray(int[,,] mArray)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
                Console.Write($"| {mArray[i, j, k]} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


PrintMultyArray(CubArray);
