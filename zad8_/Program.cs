/* Задача 8: Напишите программу, которая на вход принимает число (N), а на 
выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

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

int num = GetNumber("Введите число: ");
int n_end = 0, n_start = 2;

if (num % 2 == 0 && num > 0)
{
    n_end = num;
}
else if (num > 0)
{
    n_end = num - 1;
}
else if (num % 2 == 0 && num < 0)
{
    n_start = num;
}
else if (num < 0)
{
    n_start = num+1;
}
for (int i = n_start; i <= n_end; i += 2)
{
    Console.Write($" {i} ");
}