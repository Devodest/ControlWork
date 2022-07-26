//Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполненния алгоритма.*

int GetStringSize(string value)
{
    int strlen = 0;
    for (int i = 0; i < value.Length; i++)
    {
        strlen++;
    }
    return strlen;
}
string[] ArrayAdd(string[] arrayold, string value)
{
    string[] arrayNew = new string[arrayold.Length + 1];
    int i = 0;
    for (i = 0; i < arrayold.Length; i++)
    {
        //Console.WriteLine((arrayold.Length + 1) + " " + arrayold[i] + " " + i);
        arrayNew[i] = arrayold[i];
    }
    arrayNew[arrayNew.Length - 1] = value;
    return arrayNew;
}

int letter = 3;
string[] data = new string[] 
{
    "Hello",
    "World",
    "Hi",
    "Yes",
    ":=)",
};
Console.WriteLine(separatedWords);

string[] results = new string[0];

for (int i = 0; i < data.Length; i++)
{
    int strlen = GetStringSize(data[i]);
    if (strlen <= letter)
    {
        results = ArrayAdd(results, data[i]);
    }
}

Console.WriteLine(String.Join(" Word ",results));


