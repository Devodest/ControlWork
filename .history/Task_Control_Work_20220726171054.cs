﻿//Написать программу, которая из имеющегося массива строк формирует массив из строк, 
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

string CheckSize(string[] array, int letter)
{
    string[] results = new string[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= letter) 
        {
            results[i] = array[i];
        }
    }
}

int letter = 3;
string s =  "Text, =:), New Text, Hello World";
string [] data = s.Split(',');
string a = PrintArray(data);
Console.WriteLine(a);

/* CheckSize(a);
PrintArray(a); */


