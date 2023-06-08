using System.Text;
using UtasszallitokCLI;

List<Repulogeptipus> tipusok = new();

using StreamReader sr = new("..\\..\\..\\src\\utasszallitok.txt", Encoding.UTF8);
string fejlec = sr.ReadLine();
while (!sr.EndOfStream) tipusok.Add(new(sr.ReadLine()));

Console.WriteLine("4. feladat: " +
    $"adatsorok szama: {tipusok.Count}");

int nob = tipusok.Count(t => t.Nev.StartsWith("Boeing"));
Console.WriteLine("5. feladat: " +
    $"Boeing tipusok szama: {nob}");

var maxUtas = tipusok.MaxBy(t => t.Utas.Max);
Console.WriteLine("6. feladat: " +
    "A legtobb utast szallito repulogeptipus:\n" +
    $"\tTipus: {maxUtas.Nev}\n" +
    $"\tElso felszallas: {maxUtas.Ev}\n" +
    $"\tUtasok szama: {maxUtas.UtasString}\n" +
    $"\tSzemelyzet: {maxUtas.SzemelyzetString}\n" +
    $"\tUtazosebesseg: {maxUtas.Utazosebesseg}");

var dic = new Dictionary<string, bool>();
foreach (var skn in Sebessegkategoria.sebkatnevek)
    dic.Add(skn, tipusok.Any(t => t.Sebessegkategoria == skn));

var nincssebkat = dic.Where(kvp => kvp.Value is false).Select(kvp => kvp.Key);

Console.Write("7. feladat:\n\t");
if (nincssebkat.Any())
    foreach (var str in nincssebkat) Console.Write($"{str} ");
else Console.WriteLine("Minden sebessegkategoriabol van repulogeptipus");

using StreamWriter sw = new("..\\..\\..\\src\\utasszallitok_new.txt", false, Encoding.UTF8);
sw.WriteLine(fejlec);
foreach (var t in tipusok)
{
    sw.WriteLine(
        $"{t.Nev};" +
        $"{t.Ev};" +
        $"{t.Utas.Max};" +
        $"{t.Szemelyzet.Max};" +
        $"{t.Utazosebesseg};" +
        $"{t.Felszallotomeg / 1000};" +
        $"{Math.Round(t.Fesztav * 3.2808)}");
}
