// обращаемся к системе для генерации случайного числа
System.Random numSint = new System.Random();

// вариант 1
// генерируем число

int rndNmb = numSint.Next(10,100);
Console.WriteLine(rndNmb);
int firstNumber =rndNmb/10;
int secondNumber = rndNmb%10;
if(firstNumber>secondNumber)
{
Console.WriteLine(firstNumber);
}
else
{
    Console.WriteLine(secondNumber);
}

// Вариант 2
char[] digits = numSint.Next(10,100).ToString().ToCharArray();
Console.WriteLine(digits);
int firstNum = ((int)digits[0])-48;
int secondNum = ((int)digits[1])-48;
int resultNumber = firstNum>secondNum?resultNumber=firstNum:resultNumber=secondNum;
Console.WriteLine(resultNumber);