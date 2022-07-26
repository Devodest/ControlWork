//Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполненния алгоритма.*

string Print(int[] array)
{
    int lenght = array.Length;
    string words = String.Empty;
    for (int i = 0; i < lenght; i++)
    {
        words += ($"array{i + 1}: {array[i]} ");
    }
    return words;
}

string[] GetData (string path)
{
    string s = File.ReadAllText(path);
    string[] data = s.Split(' ');
    return data;
}

string[] Resize 