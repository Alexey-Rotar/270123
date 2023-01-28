// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// Генерация массива с указанными размерностью и диапазоном случайных значений
int[] GeneratingArray(uint size, int minValue, int maxValue)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i=0; i<size; i++)
    {
        array[i] = rnd.Next(minValue, maxValue+1);
    }
    return array;
}

// Нахождение суммы элементов на нечётных позициях
int SumOddPositionArray(int[] array)
{
    int sum=0;
    for (int i=1; i<array.Length; i+=2)
    {
        sum+=array[i];
    }
    return sum;
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

// Интерфейс
Console.WriteLine("Введите размер массива:");
uint size;
while (!uint.TryParse(Console.ReadLine(), out size) || size==0)
{
    Console.WriteLine("Некорректное значение!");            
}

Console.WriteLine("Введите минимальное значение элемента массива:");  
int minValue;
while (!int.TryParse(Console.ReadLine(), out minValue))
{
    Console.WriteLine("Некорректное значение!");            
}  

Console.WriteLine("Введите максимальное значение элемента массива:");
int maxValue;
while (!int.TryParse(Console.ReadLine(), out maxValue) || maxValue<minValue)
{
    Console.WriteLine("Некорректное значение!");            
}  	

// Вызовы методов
int[] createdArray = GeneratingArray(size, minValue, maxValue);
OutputingArray(createdArray);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {SumOddPositionArray(createdArray)}");