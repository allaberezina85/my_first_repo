// Задача 3: Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.

int[] FillRandomMas(int num)
{
    int[] mas = new int[num];
    FillMas(mas, num - 1);

    return mas;
}

void FillMas(int[] mas, int index)
{

    if (index < 0)
        return;
    Random rand = new Random();
    mas[index] = rand.Next(0, 100);
    FillMas(mas, index - 1);
}

void PrintMas(int[] mas, int index = 0)
{
    if (index == mas.Length)
        return;

    Console.Write($"{mas[index]} ");
    PrintMas(mas, index + 1);
}

void PrintInvertedMas(int[] mas, int index)
{
    if (index < 0)
        return;

    Console.Write($"{mas[index]} ");

    PrintInvertedMas(mas, index - 1);

}

Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arrey = FillRandomMas(n);

Console.WriteLine("Исходный массив: ");
PrintMas(arrey);
Console.WriteLine(" ");

Console.WriteLine("Перевернутый массив: ");
PrintInvertedMas(arrey, n - 1);
