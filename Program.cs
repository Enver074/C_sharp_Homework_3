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


Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine()!;
if (number.Length == 5)
    {
    if ((number[0])==(number[4])&&(number[1])==(number[3]))
        {
        Console.WriteLine("Да");
        }
    else
        {
        Console.WriteLine("Нет");
        }
    }
else
    {  
    Console.WriteLine("Число не пятизначное");
    }
