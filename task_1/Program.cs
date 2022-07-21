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
    {7, 3,  -9,   17,  23, -23,25},
    {3, 23, 5,   -7, 17, 5, 44},
    {23, 0,  7,  -24, 7,  -6, 79},
    {2, 10, 1, -9,  -3,  7, -99}, 
};
Console.Write(" Введите номер  строки = ");
int numLine = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите номер  столбца = ");
int numColumn = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (SearchElement(arr, numLine, numColumn));