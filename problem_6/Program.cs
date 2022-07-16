// напишите программу, которая принимает трехзначное число, а на выход выдает последнее число.

Console.Write("Введите трехзначное число : ");
int number = Convert.ToInt32(Console.ReadLine());


if (number > 99)
{
    if (number < 1000)
    Console.WriteLine(number %10);
}
else
Console.WriteLine("Введите трехзначное число");
