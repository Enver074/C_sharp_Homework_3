// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. (можно решить через строку, а можно математически)

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Задача 21


// Console.WriteLine("Введите пятизначное число");
// int number = int.Parse(Console.ReadLine()!);
// if ((number>100000)||(number<10000))
// {
//     Console.WriteLine("Введеное число не пятизначное");
// }
// if ((number>=10000) && (number<100000))
// {
//     int a = number / 10000;
//     int b = (number / 1000) % 10;
//     int c = (number / 100) % 10;
//     int d = (number / 10) % 10;
//     int e = number % 10;

//     if ((a == e)&&(b == d))
//         Console.WriteLine("ДА");
//     else
//         Console.WriteLine("Нет");

// }


// Console.WriteLine("Введите пятизначное число");
// string number = Console.ReadLine()!;
// if (number.Length == 5)
//     {
//     if ((number[0])==(number[4])&&(number[1])==(number[3]))
//         {
//         Console.WriteLine("Да");
//         }
//     else
//         {
//         Console.WriteLine("Нет");
//         }
//     }
// else
//     {  
//     Console.WriteLine("Число не пятизначное");
//     }


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


// Console.Write("Введите координаты x1: ");
// double x1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите координаты y1: ");
// double y1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите координаты z1: ");
// double z1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите координаты x2: ");
// double x2 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите координаты y2: ");
// double y2 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите координаты z2: ");
// double z2 = Convert.ToDouble(Console.ReadLine());

// double len = Math.Sqrt((Math.Pow(x1-x2, 2))+(Math.Pow(y1-y2, 2))+(Math.Pow(z1-z2, 2)));
// Console.WriteLine($"Расстояние между точками {len:f2}");


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);
int i = 1;
int result = 0;
int result1 = 0;
while(i<=num-1)

{
    result = Convert.ToInt32 (Math.Pow(i, 3));
    result1 = Convert.ToInt32(Math.Pow(num, 3));
    Console.Write($"{result}, ");
    i++;
}
Console.Write($"{result1}");
