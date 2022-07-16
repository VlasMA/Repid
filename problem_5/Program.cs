// написать программу, которая принимает число N , а на выходе показывает все целые числа от -N до N;

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());


for(int i = number * (-1); i<=number; i++)
{
    Console.Write(i+ ",");
}




