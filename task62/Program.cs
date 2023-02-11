// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

Console.Clear();
Console.Write("задайте размер равностороннего массива, элементы которого выгрузятся на экран по спирали, но не менее 3: ");
int row = Convert.ToInt32(Console.ReadLine()); //кол-во срок 
int col = row; // кол-во солбцов 


//int row = 5; //строки
//int col = 5; //столбцы

int minValue = 1;
int maxValue = 100;


void SquareMatrix(int row, int col, int minValue, int maxValue)  
{
    int[,] result = new int[row, col]; //создаем массив
    int rowStart = 0; //начало строки
    int rowEnd = result.GetLength(0) - 1; //конец строки
    int colStart = 0; //начало столбца
    int colEnd = result.GetLength(1) - 1; //конец столбца
    int count = 1; //счетчик
    int maxCount = row * col; //максимальное кол-во элементов в массиве

    while (count <= maxCount) 
    {
        for (int i = colStart; i <= colEnd; i++) //проходим по строке
        {
            result[rowStart, i] = count++;
        }
        rowStart++;
        for (int i = rowStart; i <= rowEnd; i++) //проходим по столбцу
        {
            result[i, colEnd] = count++;
        }
        colEnd--;
        for (int i = colEnd; i >= colStart; i--) //проходим по строке
        {
            result[rowEnd, i] = count++;
        }
        rowEnd--;
        for (int i = rowEnd; i >= rowStart; i--) //проходим по столбцу
        {
            result[i, colStart] = count++;
        }
        colStart++;
    }
    
    for (int i = 0; i < result.GetLength(0); i++) //выводим массив
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            Console.Write(result[i, j] + " ");
        }
        Console.WriteLine();
    }
}
SquareMatrix(row, col, minValue, maxValue);



