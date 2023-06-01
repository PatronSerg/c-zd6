// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите количество чисел M: ");
int M = Convert.ToInt32(Console.ReadLine()) , count = 0;
for (int i = 1; i <= M; i++)
{
    Console.WriteLine("Введите число {0}: ", i);
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0)
    {
        count++;
    }
}
Console.WriteLine("Количество чисел, больших 0: " + count);


