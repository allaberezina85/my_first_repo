// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 
// Пример 
// m = 2, n = 3 -> A(m,n) = 29

int GetAkkermanFunk(int numM, int numN)
{

    if (numM == 0)
    {
        return numN + 1;

    }
    else if (numN == 0)
    {
        return GetAkkermanFunk(numM - 1, 1);
    }
    else
    {
        return GetAkkermanFunk(numM - 1, GetAkkermanFunk(numM, numN - 1));
    }

}

Console.Write("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 6 && n < 4)
{
    Console.Write($"Результат вычисления функции Аккермана чисел {m} и {n}: {GetAkkermanFunk(m, n)} ");
}
else
{
    Console.Write($"Результат вычисления функции Аккермана: очень большое число.");
}

