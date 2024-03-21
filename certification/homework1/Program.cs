// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
// Пример
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


string GetListNatNums(int numStop, int numStart)
{
    if (numStart == numStop)
    { return Convert.ToString(numStart); }
    return numStart + " " + GetListNatNums(numStop, numStart + 1);
}


Console.Write("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m<=n)
    Console.WriteLine(GetListNatNums(n, m));
else
    Console.Write("Ошибка! M больше N");

