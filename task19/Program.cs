// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Напишите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99999 || num < 10000)
{
    Console.WriteLine("неверное число ");
}
else if (num / 10000 == num % 10 && (num / 1000) % 10 == (num % 100) / 10)
{
    Console.WriteLine($"{num} -> ДА");
}
else
{
    Console.WriteLine($"{num} -> НЕТ");
}


