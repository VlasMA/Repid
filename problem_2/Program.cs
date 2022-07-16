// Написать программу возведения в квадрат;


Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine()); то же самое, но короче;
string input = Console.ReadLine();
int number = Convert.ToInt32(input);

int result = number * number;

Console.WriteLine(input +  " в квадрате, будет : " + result);








