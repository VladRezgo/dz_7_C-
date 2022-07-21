//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double [,] FillArray (int lines, int columns )
{
    double[,] newArray = new double [lines, columns];
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] =  Math.Round(new Random().NextDouble() *  new Random().Next(10, 100), 2, MidpointRounding.AwayFromZero);
            
        }
    }
    return newArray;
}

void PrintArray (double[,] arr )
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("["+ arr [i,j]+"]");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размер массива");
Console.Write("Количество строк = ");
int countLines = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов = ");
int countColumns = Convert.ToInt32(Console.ReadLine());

while (countLines <= 0 | countColumns <= 0)
{
    Console.Write("Количество строк = ");
    countLines = Convert.ToInt32(Console.ReadLine());
    Console.Write("Количество столбцов = ");
    countColumns = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Полученный массив");
PrintArray(FillArray(countLines, countColumns));