/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3)*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            return result;
        }
        else
            Console.WriteLine("Вы ввели не число");
    }
    return result;
}

int num1 = GetNumber("Введите первое число: ");
int num2 = GetNumber("Введите второе число: ");

if (num1 != num2)
{
    if (num1 > num2)
    {
        Console.WriteLine($"Первое число {num1} больше второго числа {num2}");
    }
    else
    {
        Console.WriteLine($"Второе число {num2} больше первого числа {num1}");
    }
}
else
{
    Console.WriteLine($"Числа равны");
}