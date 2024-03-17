using System.Data.SqlTypes;

string s1 = "Hello world";
string s2 = s1;
s1 = "Good by world";
Console.WriteLine(s2);

string s3 = new string('*', 10);
Console.WriteLine(s2[3]);
Console.WriteLine(s1.Length);

string text = """
    Hello world
    Hello people
    Hello All
    """;
Console.WriteLine(text);

string[] cities = { "Moscow", "Tula", "Adler" };
Array.Sort(cities, (c1, c2) => c1.Length - c2.Length);
foreach(var c in cities)
    Console.WriteLine(c);

int a = 100;
int b = 200;
Console.WriteLine($"a = {a}");

string resultStr = "a = {0}\nb = {1}";
Console.WriteLine(String.Format(resultStr, a, b));

int indexStart = 1;
var cities2 = String.Join(';', cities, 1, cities.Length - indexStart);
Console.WriteLine(cities2);

foreach (var c in cities)
    Console.WriteLine(c.PadRight(10, '*'));

string s6 = "hello;by;world;string";
var s7 = s6.Split(';');
foreach(string s in s7)
    Console.WriteLine(s);


Console.WriteLine(DateTime.Now.ToLongDateString());
Console.WriteLine(DateTime.Now.ToLongTimeString());
Console.WriteLine(DateTime.Now.ToShortDateString());
Console.WriteLine(DateTime.Now.ToShortTimeString());
Console.WriteLine(DateTime.Now.DayOfWeek);

Console.WriteLine($"{DateTime.Now.ToString("dd-MM-yyyy hh*mm*ss")}");
