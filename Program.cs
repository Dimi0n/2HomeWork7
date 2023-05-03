// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

Console.WriteLine("Введите количество строк: ");
double rows = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
double columns = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите максимальное значение: ");
double maxValue = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите минимальный значение: ");
double minValue = Convert.ToDouble(Console.ReadLine());

double[,] newArray = FillArray(rows,  columns,  maxValue,  minValue);
PrintArray(newArray);

double[,] FillArray(double rows, double columns, double maxValue, double minValue)
{
    double[,] myArray = new double[Convert.ToInt32(rows), Convert.ToInt32(columns)];
    Random rnd = new Random();
    double range = maxValue - minValue;
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
         
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            myArray[i, j] = minValue + rnd.NextDouble() * range;
            myArray[i,j] = Math.Round(myArray[i,j], 1);
        }
    }
    return myArray;
}

 void PrintArray(double[,] myArray)
{ 
    for (int i = 0; i < myArray.GetLength(0); i++)
  { 
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
       Console.Write($"{myArray[i, j]} ");      
    }   
    System.Console.WriteLine();
  }
 System.Console.WriteLine();
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный значение: ");
int minValue = Convert.ToInt32(Console.ReadLine());

 int[,] FillArray(int rows, int columns, int maxValue, int minValue)
 {
    int [,] myArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            myArray[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return myArray;
 }

 void FindNumber (int[,] myArray)
 {
 Console.WriteLine("Введите индекс строки искомого числа: ");
 int rIndex = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите индекс столбца искомого числа: ");
 int cIndex = Convert.ToInt32(Console.ReadLine());

if (rIndex < 0 || rIndex > rows || cIndex < 0 || cIndex > columns)
{
    System.Console.WriteLine("числа с такими индексами в массиве нет");
}
for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            if (i == rIndex && j == cIndex)
            {
                Console.WriteLine("Искомое число: " + myArray[i,j]);
            }
           
         }
     }

}
int[,] newArray = FillArray(rows, columns, maxValue, minValue);
FindNumber (newArray);

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] myArray = new int[,] { { 1, 2, 3, 5 },
                              { 4, 5, 6, 8 },
                              { 7, 8, 9, 9 },
                              { 3, 5, 8, 5 } };

double[] AvgColumns(int[,] myArray)
{
    int rows = myArray.GetLength(0);
    int columns = myArray.GetLength(1);
    double[] avgArray = new double[columns];
    for (int j = 0; j < columns; j++)
    {
        double avg = 0;
        int sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += myArray[i, j];
        }
        avg = (double)sum / rows;
        avgArray[j] = avg;
    }
    return avgArray;
}

double[] avg = AvgColumns(myArray);
Console.Write("Среднее арифметическое каждого столбца: ");
foreach (var a in avg)
{
    Console.Write($"{a} ");
}