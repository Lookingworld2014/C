//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = new int[10];
Random rnd = new Random();

void PrintArray(int[] array)
{
    Console.WriteLine(String.Join(" ", array));
}

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(100, 1000);
    
    if (array[i] % 2 == 0)
    {
        count++;
    }
}



PrintArray(array);

Console.WriteLine($"Количество четных чисел в массиве: {count}");




//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = new int[10];
Random rnd = new Random();

void PrintArray(int[] array)
{
    Console.WriteLine(String.Join(" | ", array));
}



int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(10, 99);
    
    if (array[i] % 2 != 0)
    {
        sum += array[i];
    }
}



PrintArray(array);

Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях {sum}");



//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Random rnd = new Random();
int[] array = GetArray();


int max = array[0];
int min = array[0];

int diff = FindArray(array);

void PrintArray(int[] array)
{
    Console.WriteLine(String.Join(" - ", array));
}

int [] GetArray()

{
    int[] arr = new int[7];
    for (int i = 0; i < arr.Length; i++)
        arr[i] = rnd.Next(1,100);
    return arr;

}



int FindArray(int [] arr)
{

    for (int i = 0; i < array.Length; i++)
    {
      
        
        if (min > array[i])
        {
            min = array[i];
        }
        else if (max < array[i])
        {
            max = array[i];
        }
    }
    return max-min;
}


PrintArray(array);

Console.WriteLine($"Разница между {max} и {min} = {diff}");



№2

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Random rnd = new Random();
double[] array = GetArray();


double max = array[0];
double min = array[0];

double diff = FindArray(array);

void PrdoubleArray(double[] array)
{
    Console.WriteLine(String.Join(" - ", array));
}

double [] GetArray()

{
    double[] arr = new double[7];
    for (int i = 0; i < arr.Length; i++)
        arr[i] = rnd.NextDouble();
    return arr;

}



double FindArray(double [] arr)
{

    for (int i = 0; i < array.Length; i++)
    {
      
        
        if (min > array[i])
        {
            min = array[i];
        }
        else if (max < array[i])
        {
            max = array[i];
        }
    }
    return max-min;
}


PrdoubleArray(array);

Console.WriteLine($"Разница между {max:f3} и {min:f3} = {diff:f3}");