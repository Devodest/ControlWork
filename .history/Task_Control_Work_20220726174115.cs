//Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполненния алгоритма.*

string PrintArray(string[] array)
{
    int length = array.Length;
    string words = String.Empty;
    for (int i = 0; i < length; i++)
    {
        words += ($"Word{i + 1}: {array[i]} ");
    }
    return words;
}

int GetStringSize(string value)
{
    int strlen = 0;
    for (int i = 0; i < value.Length; i++)
    {
        strlen++;
    }
    return strlen;
}

void ArrayAdd(string[] arrayold, string value)
{
    string[] arrayNew = new string[arrayold.Length + 1];
    int i = 0;
    for (i = 0; i < arrayold.Length; i++)
    {
        arrayNew[i] = arrayold[i];
    }
    arrayNew[i + 1] = value;
}

int letter = 3;
string s = "Text,=:),New Text,Hello World";
string[] data = s.Split(',');
string separatedWords = PrintArray(data);
Console.WriteLine(separatedWords);

string[] results = new string[0];

for (int i = 0; i < data.Length; i++)
{
    int strlen = GetStringSize(data[i]);
    Console.WriteLine(strlen);
    if (strlen <= letter)
    {
        ArrayAdd(results, data[i]);
    }
}

Console.WriteLine(results.Length);
Console.WriteLine(PrintArray(results));

/* CheckSize(a);
PrintArray(a); */


