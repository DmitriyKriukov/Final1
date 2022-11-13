// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше
// либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int n = 3;
string[] array = FillArray();
Console.WriteLine("Первоначальный массив: ");
PrintArray(array);
if (FindSizeSecondArray(array) == 0)
{
    Console.WriteLine("Искомых элементов для нового массива не обнаружено");
}
else 
{
    string[] SecondArray = TransferArray(array);
    Console.WriteLine("Новый массив: ");
    PrintArray(SecondArray);
}

string[] FillArray()
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите элемент №{i+1}: ");
        array[i] = Console.ReadLine() ?? "";
    }
    return array;
}

void PrintArray(string[] array)
{
    Console.WriteLine("[" + String.Join(", ", array) + "]");
}

int FindSizeSecondArray(string[] array)
{
    int secondSize = 0;
    for (int i = 0; i < size; i++)
    {
        if(array[i].Length <= n)
        {
            secondSize++;
        }
    }
    return secondSize;
}

string[] TransferArray(string[] array)
{
    string[] SecondArray = new string[FindSizeSecondArray(array)];
    for (int i = 0, j = 0; i < size; i++)
    {
        if(array[i].Length <= n)
        {
            SecondArray[j] = array[i];
            j++;
        }
    }
    return SecondArray;
}