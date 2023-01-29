// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

// Генерация массива с указанными размерностью и диапазоном случайных значений (float)
float[] GeneratingArray(uint size, int minValue, int maxValue)
{
    float[] array = new float[size];
    Random rnd = new Random();
    for (int i=0; i<size; i++)
    {
        array[i] = rnd.Next(minValue, maxValue) + (float)(rnd.Next(0, 10))/10;
    }
    return array;
}

// Поиск индекса максимального значения
int GetIndexOfMax(float[] array)
{
    int IndexOfMax = 0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i] > array[IndexOfMax])
            IndexOfMax = i;        
    }
    return IndexOfMax;    
}

// Поиск индекса минимального значения
int GetIndexOfMin(float[] array)
{
    int IndexOfMin = 0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i] < array[IndexOfMin])
            IndexOfMin = i;        
    }
    return IndexOfMin;    
}

// Вывод массива
void OutputingArray(float[] array)
{
    Console.WriteLine("Сформированный массив:");
    Console.Write("[");
    for (int i=0; i<array.Length; i++)
        if (i<array.Length-1) 
            Console.Write(array[i].ToString("#.0") + " ");
        else
            Console.Write(array[i].ToString("#.0") + "]");
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
float[] createdArray = GeneratingArray(size, minValue, maxValue);
OutputingArray(createdArray);
Console.WriteLine($"Разница между максимальным и минимальным значениями: {createdArray[GetIndexOfMax(createdArray)]-createdArray[GetIndexOfMin(createdArray)]}");