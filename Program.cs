// Нависать Программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// Примеры:
// ["hello' "2", "world", “123”] -> [“2”, “123”] 
// ["1234", "1567", "-2", "computer science"] -> ["-2"] 
// ["Russia", "Deпmark", "Kazan"] -> []

string[] SortAndCreatNewArray(string[] array)
{
    string[] newArray = new string[array.Length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

string[] ResizeArray(string[] newArray)
{
    int newLengthArray = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
        if(newArray[i] != null)
        {
            newLengthArray++;
        }
    }
    Array.Resize(ref newArray, newLengthArray);
    return newArray;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    if (array.Length > 0 ) Console.WriteLine($"{array[array.Length-1]}]"); //Защита от пустого массива
    else Console.WriteLine("]"); 
}

string[] array = { "Russia", "Volgograd", "Kazan", "123"};  // Начальный массив
PrintArray(array);
string[] newArray = SortAndCreatNewArray(array);
newArray = ResizeArray(newArray);
PrintArray(newArray);