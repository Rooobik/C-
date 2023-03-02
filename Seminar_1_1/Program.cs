Console.WriteLine("Ведите первое число: ");
string? numLine1 = Console.ReadLine();
Console.WriteLine("Ведите второе число: ");
string? numLine2 = Console.ReadLine();
if(numLine1 != null && numLine2 != null)
{
    int number_1 = int.Parse(numLine1);
    int number_2 = int.Parse(numLine2);
    if (number_2 * number_2 == number_1)
        {
        Console.WriteLine("да");
        }
        
    else
        {
        Console.WriteLine("нет");
        }
}