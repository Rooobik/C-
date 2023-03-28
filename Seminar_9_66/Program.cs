// Задача 66:
// Задать значения M и N.
// Найти сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


/// Ввод числа из консоли

int InputNumber(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

/// Подсчет суммы чисел в промежутке от

int GetSumNumbers(int start, int end)
{
    if (start == end) return end;
    if (start < end)
    {
        return (start + GetSumNumbers(start + 1, end));
    }
    else
    {
        return (start + GetSumNumbers(start - 1, end));
    }
}

// Проверка
Console.WriteLine(GetSumNumbers(InputNumber("Введите начальное число: "), InputNumber("Введите конечное число: ")));