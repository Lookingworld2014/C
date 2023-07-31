// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Задача 2 Напишите программу, которая принимает два числа и выдает какое-то числовое значение, а какое-то меньшее.


Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());

{
if (a > b)

    Console.WriteLine($"Число {a} больше числа {b}");

if (a < b)
    Console.WriteLine($"Число {b} больше числа {a}");

}




//Задача 4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.



Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

{

if (b>max)

    max=b;
if (c>max)
    max=c;

}

Console.WriteLine(max);




//Задача 6 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).



Console.WriteLine("введите число");

int a = Convert.ToInt32(Console.ReadLine());


{

    if(a%2==0)

     Console.WriteLine($"Число {a} чётное");

    else

     Console.WriteLine($"Число {a} не чётное");
}




//Задача 8 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.WriteLine("введите число");

int a = Convert.ToInt32(Console.ReadLine());




{
 for(int i = 1; i<=a ; i++)

 if(i != 0 && i % 2 == 0)
    

{

     Console.WriteLine(i);

     i++;

}

}