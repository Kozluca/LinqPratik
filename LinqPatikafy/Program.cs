using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace LinqPatikafy
{
    public class Program
    {
        static void Main(string[] args)
        {                                                   // Listeyi tanımladık
            List<Artists> AllArtists = new List<Artists>();
            AllArtists.Add(new Artists { Name = "AJDA PEKKAN", MusicType = "POP", Year = 1968, Sales = 19950000 });
            AllArtists.Add(new Artists { Name = "SEZEN AKSU", MusicType = "POP/TÜRK HAL MÜZİĞİ", Year = 1971, Sales = 10000000 });
            AllArtists.Add(new Artists { Name = "FUNDA ARAR", MusicType = "POP", Year = 1999, Sales = 3000000 });
            AllArtists.Add(new Artists { Name = "SERTAB ERENER", MusicType = "POP", Year = 1994, Sales = 5000000 });
            AllArtists.Add(new Artists { Name = "SILA", MusicType = "POP", Year = 2009, Sales = 3000000 });
            AllArtists.Add(new Artists { Name = "SERDAR ORTAÇ", MusicType = "POP", Year = 1994, Sales = 10000000 });
            AllArtists.Add(new Artists { Name = "TARKAN", MusicType = "POP", Year = 1992, Sales = 40000000 });
            AllArtists.Add(new Artists { Name = "HANDE YENER", MusicType = "POP", Year = 1999, Sales = 7000000 });
            AllArtists.Add(new Artists { Name = "HADİSE", MusicType = "POP", Year = 2005, Sales = 5000000 });
            AllArtists.Add(new Artists { Name = "GÜLBEN ERGEN ", MusicType = "POP/TÜRK HALK MÜZİĞİ", Year = 1997, Sales = 10000000 });
            AllArtists.Add(new Artists { Name = "NEŞET ERTAŞ", MusicType = "TÜRK HALK MÜZİĞİ/TÜRK SANAT MÜZİĞİ", Year = 1960, Sales = 2000000 });


            var startwiths = from Artists in AllArtists               // S ile başlayan ümlüleri bulmak için şartları yazdık
                             where Artists.Name.StartsWith("S")
                             select Artists;
            Console.WriteLine("ADI S ile Başlayan Ünlüler");
            foreach (var name in startwiths)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;          // yazı rengini değiştirdim.
                Console.WriteLine(name.Name);
                Console.ResetColor();                                          // rengi resetledim.
            }

            Console.WriteLine("Albüm satışları 10 milyon'un üzerinde olan şarkıcılar");  // ümlüleri bulmak için şartları yazdık  
            var salesmorethen = from Artists in AllArtists
                                where Artists.Sales > 10000000                              // 10000000 dan büyük olma şartı
                                select Artists;

            foreach (var sales in salesmorethen)
            {

                Console.ForegroundColor = ConsoleColor.Blue;        // yazı rengini değiştirdim.
                Console.WriteLine(sales.Name);
                Console.ResetColor();
            }
            Console.WriteLine("2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar. (Çıkış yıllarına göre gruplayarak, alfabetik bir sıra ile yazdırınız.");

            var releaseyear = from Artists in AllArtists                 // önce şartı yadık
                              where (Artists.Year < 2000 && Artists.MusicType.Contains("POP"))     // 2000 den küçük olan ve pop müzik yapma şartı
                              orderby Artists.Name                          // sıralama yaptık
                              orderby Artists.Year                          // sıralama yaptık
                              select Artists;

            foreach (var typeandyear in releaseyear)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{typeandyear.Name}      {typeandyear.Year}");
                Console.ResetColor();
            }
            Console.WriteLine("En çok albüm satan şarkıcı");          
            var mostsell = (from Artists in AllArtists                              // ümlüleri bulmak için şartları yazdık
                            orderby Artists.Sales descending                         //büyükten küçüğe sıraladık
                            select Artists).First();                                // ilk veriyi aldık
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(mostsell.Name + "      " + mostsell.Sales);
            Console.ResetColor();


            Console.WriteLine("En yeni çıkış yapan şarkıcı");

            var firstartist = (from Artists in AllArtists                               // ümlüleri bulmak için şartları yazdık
                               orderby Artists.Year descending                          //büyükten küçüğe sıraladık
                               select Artists).First();                                 // ilk veriyi aldık
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(firstartist.Name);
            Console.ResetColor();

            Console.WriteLine("en eski çıkış yapan şarkıcı");
            Console.ForegroundColor = ConsoleColor.Green;
            var lastartist = (from Artists in AllArtists                                 // ümlüleri bulmak için şartları yazdık
                              orderby Artists.Year                                        // küçükten büyüğe sıraladık  
                              select Artists).First();                                      // ilk veriyi aldık
            Console.WriteLine(lastartist.Name);
            Console.ReadKey();

        }

    }
}
