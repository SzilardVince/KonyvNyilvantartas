using KonyvNyilvantartas;
using System.IO.Compression;
List <konyv> konyvetlen= new List<konyv>();

for (int i = 0; i < 3; i++)
{
    konyv gza = new konyv();
    Console.WriteLine($"{i+1}. könyv adatai:");
    Console.Write($"\nCím: ");
    gza.Cim = Console.ReadLine();
    Console.Write($"\nSzerző: ");
    gza.Szerzo = Console.ReadLine();
    Console.Write($"\nOldalszám: ");
    gza.Oldalszam = int.Parse(Console.ReadLine());
    Console.WriteLine();
    konyvetlen.Add(gza);

}
