using PatikafyMusicPlatform;
using System.Text.RegularExpressions;


List<Singer> singers = new List<Singer>
{
    new Singer() { FullName = "Ajda Pekkan", MusicType = "Pop", OutYear = 1968, AlbumSales = 20 },
    new Singer() { FullName = "Sezen Aksu", MusicType = "Türk Halk Müziği / Pop", OutYear = 1971, AlbumSales = 10 },
    new Singer() { FullName = "Funda Arar", MusicType = "Pop", OutYear = 1999, AlbumSales = 3 },
    new Singer() { FullName = "Sertab Erener", MusicType = "Pop", OutYear = 1994, AlbumSales = 5 },
    new Singer() { FullName = "Sıla", MusicType = "Pop", OutYear = 2009, AlbumSales = 3 },
    new Singer() { FullName = "Serdar Ortaç", MusicType = "Pop", OutYear = 1994, AlbumSales = 10 },
    new Singer() { FullName = "Tarkan", MusicType = "Pop", OutYear = 1992, AlbumSales = 40 },
    new Singer() { FullName = "Hande Yener", MusicType = "Pop", OutYear = 1999, AlbumSales = 7 },
    new Singer() { FullName = "Hadise", MusicType = "Pop", OutYear = 2005, AlbumSales = 5 },
    new Singer() { FullName = "Gülben Ergen", MusicType = "Pop / Türk Halk Müziği", OutYear = 1997, AlbumSales = 10 },
    new Singer() { FullName = "Neşet Ertaş", MusicType = "Türk Halk Müziği / Türk Sanat Müziği", OutYear = 1960, AlbumSales = 2 }
};

var starWithS = singers.Where(s => s.FullName.StartsWith('S'));

Console.WriteLine(" S ile Başlayan Sanatçılar:");

foreach (var singer in starWithS)
{
    Console.WriteLine(singer.FullName);
}

Console.WriteLine("----------------------------------");

var sales = singers.Where(s => s.AlbumSales > 10);

Console.WriteLine("Albüm Satışı On Milyonun Üzerinde Olanlar");

foreach (var singer in sales)
{
    Console.WriteLine($"Şarkıcı --> {singer.FullName}, Albüm satış sayısı --> {singer.AlbumSales}");
}

Console.WriteLine("-----------------------------------");

var before2000 = singers.Where(s => s.OutYear < 2000 && s.MusicType.Contains("Pop"))
                        .OrderBy(s => s.FullName)
                        .GroupBy(s => s.OutYear);


Console.WriteLine("2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar");

foreach (var singer in before2000)
{
    Console.WriteLine(singer.Key);
    
    foreach(var s in singer)
    {
        Console.WriteLine(s.FullName);
    }

}

Console.WriteLine("-------------------------------------");

var bestSeller = singers.OrderByDescending(s => s.FullName).FirstOrDefault();

Console.WriteLine($"En çok albüm satan ---> {bestSeller.FullName}");


Console.WriteLine("--------------------------------------");

var bestDebut = singers.OrderByDescending(s =>s.FullName).FirstOrDefault();

Console.WriteLine($"En yeni çıkış yapan şarkıcı ---> {bestDebut.FullName}");

var oldestDebut = singers.OrderBy(s => s.FullName).FirstOrDefault();

Console.WriteLine($"Sektörün en eskisi ---> {oldestDebut.FullName}");
