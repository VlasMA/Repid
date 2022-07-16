// написать программу, которая на вход принимает два числа и проверяет, является ли первоче число квадратом второго;
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2)
{
Console.WriteLine("Да," +  number1 +  " является квадратом " + number2);
}
else
Console.WriteLine("Нет," + number1 + " не является квадратом " + number2);