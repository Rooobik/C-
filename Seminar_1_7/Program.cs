// Напишите программу которая на вход принимает трехзначное число и на выходе показывает последнюю цифру этого числа

Console.WriteLine("Введите число: ");
var number = Convert.ToInt32(Console.ReadLine());

if(number > 99 && number <1000)
{
    Console.WriteLine(number%10);

}
else
Console.WriteLine("Введено не то число, дятел.");
