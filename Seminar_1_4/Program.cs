
Console.WriteLine("Введите число: ");
var number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
var number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
var number3 = Convert.ToInt32(Console.ReadLine());
if(number > number2)
{
    if(number > number3)
        {Console.WriteLine(number);}
        else
        {Console.WriteLine(number3);}
}
else
{
    if(number2>number3)
    {Console.WriteLine(number2);}
    else
    {Console.WriteLine(number3);}
}

// if(number>number2)
// {
//     { 
//         if(number>number3)
//         Console.WriteLine(number);
//     }

// else
//  {
//         Console.WriteLine(number3);
//  }
// }
// else
// {
//     if(number2>number3)
//     Console.WriteLine(number2);
// }
