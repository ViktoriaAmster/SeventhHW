// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int [,] FillAndPrintMatrix (int m, int n)
{
    int [,] array = new int[ m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array [i, j] = new Random().Next(-10,10);
            Console.Write($"{array [i,j]} ");
        }
        Console.WriteLine();
    }
    return array;
}

void SearchNumber(int [,] originalArray, int numString, int numColumn)
{
    if (numString <= originalArray.GetLength(0))
    {
        if (numColumn <= originalArray.GetLength(1))
        {
            Console.Write($"Число в {numString} строке, в {numColumn} столбце = ");
            Console.Write(originalArray[numString-1, numColumn - 1]);
        }
        else Console.Write("Числа с такими номерами строки и столбца не существует");
    }
    else Console.Write("Числа с такими номерами строки и столбца не существует");
}


int stringArray = new Random().Next(2,10);
int columnArray = new Random().Next(2,10);
Console.WriteLine($"m = {stringArray}, n = {columnArray}");
Console.WriteLine();
int [,] arrayForSearch = FillAndPrintMatrix(stringArray,columnArray);

Console.Write("Введите номер строки искомого элемента: ");
int numberString = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца искомого элемента: ");
int numberColumn = Convert.ToInt32(Console.ReadLine());
SearchNumber(arrayForSearch, numberString, numberColumn);



