// Нависать Программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// Примеры:
// ["hello' "2", "world", “123”] -> [“2”, “123”] 
// ["1234", "1567", "-2", "computer science"] -> ["-2"] 
// ["Russia", "Deпmark", "Kazan"] -> []

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

string[] array = {"Russia", "Deпmark", "Kazan", "123"};
PrintArray(array);
