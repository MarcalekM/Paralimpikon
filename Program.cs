using Paralimpikon;
using System.Text;

List<Olimpia> olimpiak = new();
using StreamReader sr = new(
    path: @"..\..\..\src\paralympics.txt",
    encoding: UTF8Encoding.UTF8);
while (!sr.EndOfStream) olimpiak.Add(new(sr.ReadLine()));
Console.WriteLine($"1. feladat: A Paralimpiát eddig {olimpiak.Count} alkalommal került megrendezésre");
int f2  = 0;
foreach (var erem in olimpiak)
{
    f2 += erem.Arany;
    f2 += erem.Ezust;
    f2 += erem.Bronz;
}
Console.WriteLine($"2. feladat: A magyar sportolók összesen {f2} darab érmet szereztek") ;
Console.WriteLine("3. feladat: A következő helyszíneken nem képviselte magát Magyarország");
var f3 = olimpiak.Where(o => o.Arany.Equals(0) && o.Ezust.Equals(0) && o.Bronz.Equals(0));
foreach (var o in f3) Console.WriteLine($"\t{o.Varos} ({o.Ev})");

Console.WriteLine("4. feladat: Országok ami több paralimpiát is rendeztek");
var f4 = olimpiak.GroupBy(o => o.Orszag).Where(o => o.Count() > 1);
foreach (var item in f4) Console.WriteLine($"\t{item.Key} ({item.Count()} alk.)");

Console.Write("5. feladat: Írjon be egy évszámot:  ");
bool val = int.TryParse(Console.ReadLine(), out int y);
if ( !val ) 
{
    Console.WriteLine("Hibás számformátum");
    return;
}
var f5 = olimpiak.SingleOrDefault(o => o.Ev == y);
if(f5 is null)
{
    Console.WriteLine($"{y}-ban nem volt paralimpia");
    return;
}
Console.WriteLine(f5);