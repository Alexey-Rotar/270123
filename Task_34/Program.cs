// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// Генерация массива указанной размерности из случайных элементов от 100 до 999
int[] GeneratingArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i=0; i<size; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}

// Вывод массива
void OutputingArray(int[] array)
{
    Console.WriteLine("Сформированный массив:");
    Console.Write("[");
    for (int i=0; i<array.Length; i++)
        if (i<array.Length-1) 
            Console.Write($"{array[i]}, ");
        else
            Console.Write($"{array[i]}]");
            Console.WriteLine("");
}

// Поиск чётных элементов в массиве
int FindingEvenArray(int[] array)
{
    int count=0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]%2==0)
        count++;
    }
    return count;
}

Console.WriteLine("Введите размер массива:");
if (int.TryParse(Console.ReadLine(), out int size))
{
    int[] createdArray = GeneratingArray(size);
    OutputingArray(createdArray);
    Console.WriteLine($"Чётных элементов в массиве: {FindingEvenArray(createdArray)}");
}
else
    Console.WriteLine("Некорректное значение!");