// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число");
// int a=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int b=Convert.ToInt32(Console.ReadLine());

// int Fun()
// {
//     int result=1;
//     int i=0;
//     for(i=1; i<=b; i++)
//     {
//         result=result*a;
//     }
//     return result;
// }
// Console.WriteLine(Fun());

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Допустимо введение числа до 9999.

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int GetSum()
{
    int result=0;
    if(num<100)
    {
        int num1=num/10;
        int num2=num%10;
        result=num1+num2;
    }
    else if(num>=100 && num<1000)
    {
        int n1=num/100;
        int n2=num/10 %10;
        int n3=num %10;
        result=n1+n2+n3;
    }
    else
    {
        int c1=num/1000;
        int c2=num/100 %10;
        int c3=num/10 %10;
        int c4=num%10;
        result=c1+c2+c3+c4;
    }
    return result;
}
Console.WriteLine(GetSum());

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int [] array = new int[8];

// void GetArray()
// {
//     for(int i=0; i<array.Length; i++)
//     {
//         array[i]= new Random().Next(0,100);
//         Console.Write(array[i]+" ");
//     }
// }
// GetArray();