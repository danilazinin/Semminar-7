// Задача 43:
// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("\n Задача 43"
+"\nНахождение точки пересечения прямых: y = k1 * x + b1 и y = k2 * x + b2"
+"\nЗадайте константы b1, k1, b2, k2 через запятую:");

double[] numbers = StringToNum(Console.ReadLine());

PrintArray(numbers);
Console.WriteLine();


if (numbers.Length != 4)
{
    Console.WriteLine("Введено недопустимое значение, введите 4 натуральных числа через запятую");
}
else
{
    double x = 0;
    double y = 0;
    x = (numbers[2] - numbers[0]) / (numbers[1] - numbers[3]);
    y = numbers[1] * x + numbers[0];
    Console.WriteLine($"Точка пересечения ( {x} ; {y} )");
}

double[] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    double[] numbers = new double[count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input[i] != ',')
        {
            if (i != input.Length - 1)
            {
                temp = temp + input[i].ToString(); // x=x+y и х+=у
                i++;
            }
            else
            {
                temp += input[i].ToString();
                break;
            }
        }
        numbers[index] = Convert.ToDouble(temp);
        index++;
    }
    return numbers;
}
void PrintArray(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write(" ]");
}
