// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int [,] FillAndPrintMatrix (int m, int n)
{
    int [,] array = new int[ m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array [i, j] = new Random().Next(0,10);
            Console.Write($"{array [i,j]} ");
        }
        Console.WriteLine();
    }
    return array;
}


void ColumnAverage (int[,] arr)
{
    double sumInColumn = 0;
    double calcAverage = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
           sumInColumn += arr[i,j]; 
        }
        calcAverage = sumInColumn / arr.GetLength(0);
        Console.WriteLine($"среднее арифметическое {j+1} столбца = {Math.Round(calcAverage, 2)}");
        sumInColumn = 0;
    }
}

int stringArray = new Random().Next(2,10);
int columnArray = new Random().Next(2,10);
Console.WriteLine($"m = {stringArray}, n = {columnArray}");
Console.WriteLine();
int [,] arrayForAverage = FillAndPrintMatrix(stringArray,columnArray);
ColumnAverage(arrayForAverage);

