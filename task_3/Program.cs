// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int [,] FillArray (int lines, int columns )
{
    int[,] newArray = new int [lines, columns];
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] =  new Random().Next(1, 10);
            
        }
    }
    return newArray;
}

void PrintArray (int[,] arr )
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write( arr [i,j] +",");
        }
        Console.WriteLine();
    }
}

void  CountAverage (int[,] arr)
{
   for (int j = 0; j < arr.GetLength(1); j++)
   {
       int summ = 0;
       int average = 0;
       for (int i = 0; i < arr.GetLength(0); i++)
       {
            summ+=arr[i,j];
       }
       average = summ / arr.GetLength(0);
       Console.WriteLine($"Среднее арифметическое столбца {j+1}  = {average}");
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

Console.WriteLine("массив");
int [,] array =  FillArray(countLines, countColumns);
PrintArray(array);
CountAverage(array);
