// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 == number2)
{
    Console.Write("Числа равны между собой!");
}
else{
    if (number1 > number2)
    {
    Console.Write("Первое число ");
    Console.Write(number1);
    Console.Write(" больше второго ");
    Console.Write(number2);
    }
    else
    {
    Console.Write("Второе число ");
    Console.Write(number2);
    Console.Write(" больше первого ");
    Console.Write(number1);
    }
}