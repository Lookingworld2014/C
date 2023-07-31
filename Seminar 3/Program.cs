//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да







Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
char[] arr = num.ToString().ToCharArray(); 


if (num / 10000 == 0 || num / 10000 > 9)
    Console.WriteLine("Неправильно введено число!");
else
    Polindrom(arr);

void Polindrom(char[] array) 
{

    if(array[0] == array[4] && array[1] == array[3])
            System.Console.WriteLine("Это палиндром");
    else
            System.Console.WriteLine("Это не палиндром");
    } 




//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53





Console.WriteLine("Введите х1");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите у1");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z1");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите х2");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите у2");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z1");
double z2 = Convert.ToInt32(Console.ReadLine());

double x3 = Math.Pow(x1-x2, 2);
double y3 = Math.Pow(y1-y2, 2);
double z3 = Math.Pow(z1-z2, 2);

Console.WriteLine($"Oтрезок{Math.Sqrt(x3 + y3 + z3)}");




//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125




Console.WriteLine("Введите число: "); 
int number = Math.Abs(Convert.ToInt32(Console.ReadLine())); 
 
for (int i = 1; i <= number; i++) 
{ 
 Console.WriteLine(i*i*i); 
}