using Nepessegg;
using System.Text;

List<Orszag> orszagok = new();

using StreamReader sr = new(@"../../../adatok-utf8.txt", Encoding.UTF8);
_ = sr.ReadLine();
while (!sr.EndOfStream) orszagok.Add(new(sr.ReadLine()));
   