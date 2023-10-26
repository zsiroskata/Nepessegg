using Nepessegg;
using System.Text;

List<Orszag> orszagok = new();

using StreamReader sr = new(@"../../../adatok-utf8.txt", Encoding.UTF8);
_ = sr.ReadLine();
while (!sr.EndOfStream) orszagok.Add(new(sr.ReadLine()));

Console.WriteLine("3.feladat");
Console.WriteLine($"beolvasott sorok száma: {orszagok.Count}");
Console.WriteLine("\n4.feladat");
