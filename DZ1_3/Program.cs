// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 % 2 == 0)
{
    Console.Write("Введенное число четное ");
    Console.Write(number1);
}
else
{
    Console.Write("Введенное число нечетное ");
    Console.Write(number1);
}