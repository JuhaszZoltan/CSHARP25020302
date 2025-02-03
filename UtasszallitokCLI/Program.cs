using System.Text;
using UtasszallitokCLI;

const string PATH = "C:\\PROJECTS\\CSHARP25020302\\UTASSZALLITOK";

string[] kategoriaNevek = [
    "Alacsony sebességű",
    "Szubszonikus",
    "Transzszonikus",
    "Szuperszonikus"];

List<Utassallito> utassallitok = [];

using StreamReader sr = new($"{PATH}\\utasszallitok.txt", Encoding.UTF8);
string fejlec = sr.ReadLine();
while (!sr.EndOfStream) utassallitok.Add(new(sr.ReadLine()));

Console.WriteLine($"4. feladat: Adatsorok száma: {utassallitok.Count}");

var f5 = utassallitok.Count(u => u.Tipus.StartsWith("Boeing"));
Console.WriteLine($"5. feladat: Boeing típusok száma: {f5}");

var f6 = utassallitok.MaxBy(u => u.Utas.Max);
Console.WriteLine("6. feladat: Legtöbb utast szállító repülőgéptípus:");
Console.WriteLine(f6);

Console.WriteLine("7. feladat:");
var f7 = kategoriaNevek.Except(
    utassallitok
    .Select(u => u.Sebessegkategoria.Kategorianev)
    .Distinct());
if (f7.Any()) Console.WriteLine($"\t{string.Join('-', f7)}");
else Console.WriteLine("\tMinden sebességkategóriából van repülőgéptípus");

