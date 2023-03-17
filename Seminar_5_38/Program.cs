int GetNumberConsole(string message)
{
    int number = 0;
    Console.WriteLine(message);
    string? strValue = Console.ReadLine();
    if (!int.TryParse(strValue, out number))
    {
        Console.WriteLine("Введите цифровое значение!");
        Environment.Exit(-1);
    }
    return number;
}

double[] FillArray(double[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble()*100;
    }
    return array;
}

double DiffMinMax(double[] array)
{
    int size = array.Length;
    double min = array[0];
    double max = min;
    for (int i = 0; i < size; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    return max - min;
}

int size = GetNumberConsole("Введите размер массива:");
double[] array = new double[size];
array = FillArray(array);

Console.WriteLine($"В массиве: [{ string.Join("; ", array)}]\n\nРазница между макс. и мин. значением состовляет: {DiffMinMax(array)}");