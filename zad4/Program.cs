/* Задача 4: Задача 4: Напишите программу, которая принимает на вход три числа
и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

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

int num1=GetNumber("Введите первое число: ");
int num2=GetNumber("Введите второе число: ");
int num3=GetNumber("Введите третье число: ");

int max=num1;
if(num2>max)
{
    max=num2;
}
if(num3>max)
{
    max=num3;
}
Console.WriteLine($"Из 3-х введенных чисел максимальное {max}! ");