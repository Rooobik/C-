void IfSquared(int num1, int num2)
{
    if(num2 == num1*num1)
        {
            Console.WriteLine($"{num2} - квадрат {num1}");
        }
    else
        {
        
        Console.WriteLine($"{num1} - не квадрат {num2}");   
        }
}
int firstNum=int.Parse(Console.ReadLine()??"0");
int secondNum=int.Parse(Console.ReadLine()??"0");

IfSquared(firstNum,secondNum);
IfSquared(secondNum,firstNum);