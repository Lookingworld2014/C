// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Задача 10 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа



Console.WriteLine("Введите трёхзначное число");
int a = Convert.ToInt32(Console.ReadLine());

if (a / 100 == 0 || a / 100 > 9)
    Console.WriteLine("Неправильно введено число!");
else
{
    a = a % 100; 
    a = a / 10;
}
Console.WriteLine(a);



//Задача 13 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет



Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());


char[] arr = num.ToString().ToCharArray();
int count = 0;

Console.WriteLine();

FindNumber(arr);




void ReadArray(char[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        count = i;
        count++;
    }
}

void FindNumber(char[] array)

{
    ReadArray(arr);

    Console.WriteLine();

    if (count > 2)

         Console.WriteLine(arr[2]);

    else 

        Console.WriteLine("Третьего числа нет");

    }
    
    
    
   // Задача 15 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
   
   
   
   Console.Write("Введите номер дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
string nameOfTheDay = " ";

switch (dayNumber)
{
  case 1:
    nameOfTheDay = "Понедельник";
    break;
  case 2:
    nameOfTheDay = "Вторник";
    break;
  case 3:
    nameOfTheDay = "Среда";
    break;
  case 4:
    nameOfTheDay = "Четверг";
    break;
  case 5:
    nameOfTheDay = "Пятница";
    break;
  case 6:
    nameOfTheDay = "Суббота";
    break;
  case 7:
    nameOfTheDay = "Воскресенье";
    break;
  default:
    Console.WriteLine("В неделе только семь дней");
    break;
}
    Console.WriteLine(nameOfTheDay);

    if (dayNumber == 6 || dayNumber == 7)
        Console.WriteLine("Это выходной! Гуляем!");
    else if (dayNumber < 6 && dayNumber > 0)
        Console.WriteLine("Сегодня будни... Кошмар...");
    else 
        Console.WriteLine("От работы не убежишь!");