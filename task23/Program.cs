// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine("До кого числа делать таблицу?");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
  
while (num >= i){
    Console.WriteLine($"|{i}|{Math.Pow(i, 3)}");
    i++;
}