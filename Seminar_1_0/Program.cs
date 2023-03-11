//Напишите программу, которая на вход принимает
//число и выдаёт его квадрат (число умноженное на
//само себя). 

Console.WriteLine("Ведите число: ");
//считываем данные с консоли
string? inputNum = Console.ReadLine();
//проверка что значение не пустое
if(inputNum != null)
{
    //парсим(Анализируем, превращаем) строку в число
   int number = int.Parse(inputNum);

   //находим квадрат числа
   int outNum = (int)Math.Pow(number,2);

    Console.WriteLine("Квадрат числа: "+outNum);
}