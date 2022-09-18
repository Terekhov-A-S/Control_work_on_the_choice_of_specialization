/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами */
Console.Clear();
void PrintArray(string [] array)          // Метод печатает массив
{
    Console.Write("[");
    for (int i = 0; i < array.GetLength(0); i++)
    {
       Console.Write(array[i]  + " ");
    }
    Console.Write("]");
}

Console.WriteLine("Программа находит строки, введенные пользователем, в которых не более трех символов");
Console.Write("Задайте желаемое количество строк: ");
int length = Convert.ToInt32(Console.ReadLine());
string[] array = new string [length];
Console.WriteLine("Введите значение строки: ");
int counter = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    array[i] = Convert.ToString(Console.ReadLine());
    if(array[i].Length <= 3) counter++;
}
string[] secondArray = new string [counter];
counter = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    if (array[i].Length <= 3)
    {
        secondArray[counter] = array[i];
        counter++;
    }
}
PrintArray(array);
Console.Write(" - ");
PrintArray(secondArray);



