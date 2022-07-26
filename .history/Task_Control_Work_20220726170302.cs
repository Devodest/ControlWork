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

void CheckSize(string[] array)
{
    int length = array.Length;
    int str = array;
    for (int i = 0; i < length; i++)
    {
        if (length <= 3) 
        {

        }
    }
}

string s =  "Text, =:), New Text, Hello World";
string [] data = s.Split(',');
string a = PrintArray(data);
Console.WriteLine(a);
/* CheckSize(a);
PrintArray(a); */


