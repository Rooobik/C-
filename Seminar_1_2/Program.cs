// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите число: ");
var number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
var number2 = Convert.ToInt32(Console.ReadLine());
if(number>number2)
{
Console.WriteLine("Число А болше числа Б");
}
else
Console.WriteLine("Число Б болше числа А");