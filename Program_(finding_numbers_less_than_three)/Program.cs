/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами */
Console.Clear();
void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("]");
}
Console.WriteLine("_-=* ПРОГРАММА НАХОДИТ СТРОКИ, ВВЕДЕННЫЕ ПОЛЬЗОВАТЕЛЕМ, В КОТОРЫХ НЕ БОЛЕЕ ТРЕХ СИМВОЛОВ *=-_");
Console.Write("Задайте желаемое количество строк: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
string[] array = new string[arrayLength];
int count = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    Console.Write($"Введите значение строки {i + 1}: ");
    array[i] = Convert.ToString(Console.ReadLine());
    if (array[i].Length <= 3) count++;
}
string[] filteredArray = new string[count];
count = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    if (array[i].Length <= 3)
    {
        filteredArray[count] = array[i];
        count++;
    }
}
Console.WriteLine("*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*");
Console.WriteLine();
Console.Write("Массив с Вашими значениями: ");
PrintArray(array);
Console.Write("Массив с отобранными значениями: ");
PrintArray(filteredArray);
Console.WriteLine();
Console.WriteLine("*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*");
