//Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполненния алгоритма.*

string Print(string[] array)
{
    int lenght = array.Length;
    string words = String.Empty;
    for (int i = 0; i < lenght; i++)
    {
        words += ($"array{i + 1}: {array[i]} ");
    }
    return words;
}

string[] SizeCheck ( string[] array)
{
    string[] result = new string[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result = array[i];
        }
    }
}

