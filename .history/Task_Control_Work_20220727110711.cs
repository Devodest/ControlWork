using System.Diagnostics;

var sw = new Stopwatch();

sw.Start();

string[] ArrayAdd(string[] arrayOld, string value)

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

string s = File.ReadAllText("malen_kii_princ.txt");
string[] data = s.Split(' ');

string[] results = new string[0];

for (int i = 0; i < data.Length; i++)
{
    int strLen = data[i].Length;
    if (strLen <= letter)
    {
        results = ArrayAdd(results, data[i]);
    }
}

File.WriteAllText("out.txt", String.Join(", ", results));
Console.WriteLine(results.Length);

sw.Stop();
Console.WriteLine($"Time Spent: {sw.Elapsed}мс");
