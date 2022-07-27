﻿string[] ArrayAdd(string[] arrayOld, string value)
{
    string[] arrayNew = new string[arrayOld.Length + 1];
    int i = 0;
    for (i = 0; i < arrayOld.Length; i++)
    {
        arrayNew[i] = arrayOld[i];
    }
    arrayNew[arrayNew.Length - 1] = value;
    return arrayNew;
}

int letter = 3;
string s = ""
string[] data = new string[]
{
    "Hello",
    "World",
    "Hi",
    "Yes",
    ":=)",
    "1234",
    "123",
    "Russia",
};

string[] results = new string[0];

for (int i = 0; i < data.Length; i++)
{
    int strLen = data[i].Length;
    if (strLen <= letter)
    {
        results = ArrayAdd(results, data[i]);
    }
}

Console.WriteLine(String.Join(", ", results));

