/* Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int CountPositive(int m)
{
    int countPos = 0;
    for (int i = 0; i < m; i++)
    {
        //int number = int.Parse(Console.ReadLine());
        int number = ReadInt("Введите число -> ");
        if (number > 0)
        {
            countPos ++;
        }
    }
    return countPos;
}

int m = ReadInt("Введите количеcтво чисел -> ");
System.Console.WriteLine($"Пользователь ввёл {CountPositive(m)} положительных чисел");