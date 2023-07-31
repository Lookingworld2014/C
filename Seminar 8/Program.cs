//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

int[,] arr = GetArray();
Console.WriteLine();
ChangeArray(arr); 

 

int[,] GetArray()
{
    int[,] arr = new int[3,4];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 11);
            Console.Write(arr[i, j] + " ");
        }
    }

    return arr;
}

void ChangeArray(int[,] arr)

    {

         for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1) - 1; j++)
            {
                for (int k = j + 1; k < arr.GetLength(1); k++)
                {
                    if (arr[i, k] > arr[i, j])
                    {
                        int tmp = arr[i, k];
                        arr[i, k] = arr[i, j];
                        arr[i, j] = tmp;
                    }
                }
            }
        }
        for (int i = 0; i < arr.GetLength(0); i++)
{
    Console.WriteLine();
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[i, j] + " ");
    }
}

    }


 
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] arr = GetArray();
Console.WriteLine();
 

 

int[,] GetArray()
{
    int[,] arr = new int[3,4];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 11);
            Console.Write(arr[i, j] + " ");
        }
    }

    return arr;
}



int minSum = int.MaxValue;
int minIndex = -1;

for (int i = 0; i < arr.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum += arr[i, j];
    }
    if (sum < minSum)
    {
        minSum = sum;
        minIndex = i;
    }
}
 
 System.Console.WriteLine($"наименьшая сумма элементов в строке {minIndex+1}");
 
 
 //Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int[,] matrix1 = {
    {2, 4},
    {3, 2}
};

int[,] matrix2 = {
    {3, 4},
    {3, 3}
};

int rows1 = matrix1.GetLength(0);
int cols1 = matrix1.GetLength(1);
int rows2 = matrix2.GetLength(0);
int cols2 = matrix2.GetLength(1);


int[,] arr = new int[rows1, cols2];

for (int i = 0; i < rows1; i++)
{
    for (int j = 0; j < cols2; j++)
    {
        int sum = 0;
        for (int k = 0; k < cols1; k++)
        {
            sum += matrix1[i, k] * matrix2[k, j];
        }
        arr[i, j] = sum;
    }
}


for (int i = 0; i < rows1; i++)
{
    for (int j = 0; j < cols2; j++)
    {
        Console.Write(arr[i, j] + " ");
    }
   
}




//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

int[,,] arr = new int[2,2,2];

int[,,] GetArray()
{
  

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < arr.GetLength(2); k++)
           
            arr[i, j, k] = i*2+j*3+k;
            
        }
    }

    return arr;
}

void PrintArray(int[,,]arr)
{

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k = 0; k < arr.GetLength(2); k++)
        {
            Console.Write(arr[i, j, k] + "(" + i + "," + j + "," + k + ") ");
        }
        Console.WriteLine();
    }
}
}

arr = GetArray();
PrintArray(arr);


//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07



int[,] arr = new int[4, 4];

 void Snail(int[,] array)
{
    const int n = 4;
    int x = 0, y = 0, dx = 1, dy = 0;

    for (int i = 1; i <= n * n; i++)
    {
        array[x, y] = i;
        int nx = x + dx;
        int ny = y + dy;
        if (nx < 0 || nx >= n || ny < 0 || ny >= n || array[nx, ny] != 0)
        {
            int temp = dx;
            dx = -dy;
            dy = temp;
        }
        x += dx;
        y += dy;
    }

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write("{0,2} ", array[i, j]);
        }
        Console.WriteLine();
    }
}


Snail(arr);