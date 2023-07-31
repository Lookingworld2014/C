//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.

//0,5 7 -2 -0,2

//1 -3,3 8 -9,9

//8 7,8 -7,1 9

Random rnd = new Random();
double[,] array = new double [3,4];


for (int i = 0; i < array.GetLength(0); i++)
{

   Console.WriteLine();
   
   for (int j = 0; j < array.GetLength(1); j++)
   {
      
      array[i,j] = new Random().NextDouble()*11;
      Console.Write(array[i,j] + "|");
   }
}



//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] array = new int[3, 4];

for (int j = 0; j < array.GetLength(1); j++) {
    int sum = 0;
    int count = 0;

    for (int i = 0; i < array.GetLength(0); i++) {
        array[i, j] = new Random().Next(1, 11);
        Console.Write(array[i, j] + "|");

        sum += array[i, j];
        count++;
    }

    double arMean = (double)sum / count;
    Console.WriteLine($"Среднее арифметическое элементов в столбце {j + 1}: {arMean}");
}