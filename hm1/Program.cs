// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


using System;
using static System.Console;
Clear();

WriteLine("Введите 5 значное число");
int number = Convert.ToInt32(ReadLine());

if(number<10000 || number>99999)
{
    WriteLine($"{number} Введеное вами число не пятизначное, повторите попытку");
}
else
{
        int i = 0;
        int k=10000;
        int convNumber = 0;
        int auxNumber = number;
        while(i<5)
        {
            convNumber = convNumber + (auxNumber%10)*k;
            auxNumber/=10;
            k/=10;
            i++;
        }
        WriteLine(convNumber==number? $"{number} это палидром" : $"{number} это не палидром");
}