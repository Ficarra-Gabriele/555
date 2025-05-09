//primo es
List<int> a = new List<int>();
for (int i = 1; i < 11; i++)
{
    a.Add(i);
    Console.Write(a[i - 1] + ";");
}
Console.WriteLine();

//secondo es
int b = 0;
foreach (int c in a)
{
    b += c;
}
Console.WriteLine(b);

//terzo es
List<int> d = new List<int>(a.Count());
foreach (int e in a)
{
    if (e % 2 == 0)
    {
        d.Add(e);
    }
}
for (int i = 0; i < d.Count; i++)
{
    Console.Write(d[i] + ";");
}
Console.WriteLine();

//quarto es
List<string> f = new List<string> { "guapo", "ciao", "ciao", "guapissimo", "guapos" };
List<string> g = new List<string>();

foreach (string h in f)
{
    if (h != "ciao")
    {
        g.Add(h);
    }
}

foreach (string h in g)
{
    Console.Write(h + ";");
}
Console.WriteLine();

//quinto es
List<int> j = [1, 2, 3, 4, 5];
Console.WriteLine("dammi un numero");
int k = int.Parse(Console.ReadLine());

for (int i = 0; i < j.Count(); i++)
{
    if (k == j[i])
    {
        Console.WriteLine(i);
        j.RemoveAt(i);
    }
}

//sesto es
List<int> l = [1, 2, 3, 4, 5];
List<int> m = [0, 8, 3, 4, 9];
List<int> n = new List<int>(l.Count());
for (int i = 0; i < 5; i++)
{
    if (l[i] == m[i])
    {
        n.Add(m[i]);
    }
}
foreach (int x in n)
{
    Console.Write(x + ";");
}
Console.WriteLine();
