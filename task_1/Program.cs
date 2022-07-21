/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
значение этого элемента или же указание, что такого элемента нет.*/

string  SearchElement (int[,] searchArr, int x, int y)
{
   if( x <= searchArr.GetLength(0) && y <= searchArr.GetLength(1)-1) 
   return  "Элемент массива = "+Convert.ToString(searchArr [x,y]);
   return "Такого элемента в массиве нет";
}

int[,] arr = new int [,] 
{
    {1, 4,  5,   7,  19, -23},
    {3, 23, 5,   -7, 17, 5},
    {5, 0,  10,  13, 7,  -6},
    {6, 10, -13, 5,  6,  8},
};
Console.Write(" Введите номер  строки = ");
int numLine = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите номер  столбца = ");
int numColumn = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (SearchElement(arr, numLine, numColumn));