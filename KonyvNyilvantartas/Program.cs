using KonyvNyilvantartas;
using System.IO.Compression;
List <konyv> konyvetlen= new List<konyv>();

for (int i = 0; i < 3; i++)
{
    konyv gza = new konyv();
    Console.WriteLine($"{i+1}. könyv adatai:");
    Console.Write($"\tCím: ");
    gza.Cim = Console.ReadLine();
    Console.Write($"\tSzerző: ");
    gza.Szerzo = Console.ReadLine();
    Console.Write($"\tOldalszám: ");
    gza.Oldalszam = int.Parse(Console.ReadLine());
    Console.WriteLine();
    konyvetlen.Add(gza);

}
Console.WriteLine("Rögzített könyvek listája:");
int r = 0;
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"\t- {konyvetlen[i].Cim} ({konyvetlen[i].Szerzo}) - {konyvetlen[i].Oldalszam} oldal");
    r += konyvetlen[i].Oldalszam;
}
Console.WriteLine();
Console.WriteLine($"Összesen elolvasandó: {r} oldal");