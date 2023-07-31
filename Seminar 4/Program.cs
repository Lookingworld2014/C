//- **Задача 25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.   
//3, 5 -> 243 (3⁵)  
//2, 4 -> 16


Console.Write("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень ");
int b = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"Число {a} возведённое в степень {b} = " + Math.Pow(a,b));





//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    
//452 -> 11
//82 -> 10
//9012 -> 12





int nomber = Vvod("Input nomber");
System.Console.WriteLine(Sum(n));

int Sum(int n)
{
    int res = 0;
    while(n>0)
    
    {
        res += n % 10;
        n = n / 10;
    }
    return res;

}

int Vvod(string nomber)
{
    System.Console.WriteLine("Input nomber");
    string nam = Console.ReadLine();
    int result = int.Parse(nam);
    return result;
}







//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
    
    //1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
    
    //6, 1, 33 -> [6, 1, 33]

ReadArray(FeelArray());

int [] FeelArray()

{

int [] arr = new int[8];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0,10);
   

}

return arr;


}

void ReadArray(int [] arr)

{

string array = String.Join(" ", arr);
System.Console.WriteLine(array);

}