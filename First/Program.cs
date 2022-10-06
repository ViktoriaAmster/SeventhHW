// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


void FillAndPrintMatrix (int m, int n)
{
    double [,] array = new double[ m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array [i, j] = new Random().Next(-10,10) + new Random().NextDouble();
            Console.Write($"{Math.Round(array [i,j], 2)} ");
        }
        Console.WriteLine();
    }
}

int stringArray = new Random().Next(2,10);
int columnArray = new Random().Next(2,10);
Console.WriteLine($"m = {stringArray}, n = {columnArray}");
Console.WriteLine();
FillAndPrintMatrix(stringArray,columnArray);

