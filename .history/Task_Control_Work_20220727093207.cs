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
string s = "Когда я встречал взрослого, который казался мне разумней и понятливей других,"  +
"я показывал ему свой рисунок № 1 — я его сохранил и всегда носил с собой. Я хотел знать,"  +
"вправду ли этот человек что-то понимает. Но все они отвечали мне: «Это шляпа». "           +
"И я уже не говорил с ними ни об удавах, ни о джунглях, ни о звездах. Я применялся к их понятиям. " +
"Я говорил с ними об игре в бридж и гольф, о политике и о галстуках. " + 
"И взрослые были очень довольны, что познакомились с таким здравомыслящим человеком.";

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

Console.WriteLine(String.Join(", ", results));

sw.Stop();

Console.WriteLine($"Time Spent: {sw.ElapsedMilliseconds}");
