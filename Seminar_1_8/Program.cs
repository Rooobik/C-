// задача 8

Console.WriteLine("Введите число: ");
var number = Convert.ToInt32(Console.ReadLine());

for (int i=2; i<=number;i=i+2)
{
    Console.Write(i + " ");
}
