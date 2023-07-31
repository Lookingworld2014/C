//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("ВВедите первое число");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("ВВедите последнеечисло");
int n = Convert.ToInt32(Console.ReadLine());



int FindSumAllElements(int m, int n)

{
Console.Write(m + " ");
 if(m==n) return m;
 return m + FindSumAllElements(m+1,n);

}
Console.WriteLine(FindSumAllElements(m,n));



//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

System.Console.WriteLine("Input minimal number: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal number: ");
int n = Convert.ToInt32(Console.ReadLine());

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ackermann(m - 1, 1);
    else return Ackermann(m - 1, Ackermann(m, n - 1));
}
System.Console.WriteLine(Ackermann(m,n));





//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("ВВедите число ");
int n = Convert.ToInt32(Console.ReadLine());

string FindNombers(int n)
{

    if(n==1) return n + " ";
    return n + " " + FindNombers(n-1);
}

System.Console.WriteLine(FindNombers(n));
