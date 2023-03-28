// Задача 64
// Задайте значение N.
// Вывести все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/// Ввод числа из терминала / консоли

int InputNumber(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}


/// Возвращает строку чисел от START до END

string GetListNumbers(int start, int end)
{
    if (start < end) return "Начальное значение меньше конечного.";
    if (start == end) return end.ToString();
    return (start + ", " + GetListNumbers(start - 1, end));
}
Console.WriteLine(GetListNumbers(InputNumber("Введите начальное число: "), InputNumber("Введите конечное число: ")));