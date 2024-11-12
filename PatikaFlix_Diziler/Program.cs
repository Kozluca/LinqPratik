using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PatikaFlix_Diziler
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            List<TvSeries> seriesList = new List<TvSeries>();
            seriesList.Add(new TvSeries() { Name = "Avrupa Yakası", ProductYear = 2004, Type = "Komedi", PublicationDate = 2004, Director = "Yülsel Aksu", PublishedPlatform = "Kanal D" });
            seriesList.Add(new TvSeries() { Name = "Yalan Dünya", ProductYear = 2012, Type = "Komedi", PublicationDate = 2012, Director = "Gülseren Buda Başkaya", PublishedPlatform = "Fox" });
            seriesList.Add(new TvSeries() { Name = "Jet Sosyete", ProductYear = 2018, Type = "Komedi", PublicationDate = 2018, Director = "Gülseren Buda Başkaya", PublishedPlatform = "TV 8" });
            seriesList.Add(new TvSeries() { Name = "Dadı", ProductYear = 2006, Type = "Komedi", PublicationDate = 2006, Director = "Yusuf Pirhasan", PublishedPlatform = "Kanal D" });
            seriesList.Add(new TvSeries() { Name = "Belalı Baldız", ProductYear = 2007, Type = "Komedi", PublicationDate = 2007, Director = "Yülsel Aksu", PublishedPlatform = "Kanal D" });
            seriesList.Add(new TvSeries() { Name = "Arka Sokaklar", ProductYear = 2004, Type = "Polisiye,Dram", PublicationDate = 2004, Director = "Orhan Oğuz", PublishedPlatform = "Kanal D" });
            seriesList.Add(new TvSeries() { Name = "Aşk-ı Memnu", ProductYear = 2008, Type = "Dram,Romantik", PublicationDate = 2008, Director = "Hilal Saral", PublishedPlatform = "Kanal D" });
            seriesList.Add(new TvSeries() { Name = "Muhteşem Yüzyıl", ProductYear = 2011, Type = "Tarihi,Drm", PublicationDate = 2011, Director = "Mercan Çilingiroğlu", PublishedPlatform = "Star" });
            seriesList.Add(new TvSeries() { Name = "Yaprak Dökümü", ProductYear = 2006, Type = "Dram", PublicationDate = 2006, Director = "Serdar Akar", PublishedPlatform = "Kanal D" });
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var series in seriesList)
               
                Console.WriteLine($"{series.Name}   {series.ProductYear}  {series.Type}  {series.PublicationDate}  {series.Director}  {series.PublicationDate}");

            Console.ResetColor();
            List<NewList> newLists = new List<NewList>();
        Başla:
            Console.WriteLine("DİZİ OLUŞTURMAK İSTER MİSİNİZ");
            string answer = Console.ReadLine();
            answer = answer.ToLower();
            Console.ForegroundColor= ConsoleColor.Magenta;
        Orta:
            if (answer == "evet")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("DİZİNİN ADINI GİRİN");
                string seriesname = Console.ReadLine();
                Console.WriteLine("DİZİNİN TÜRÜNÜ GİRİN");
                string seriestype = Console.ReadLine();
                Console.WriteLine("DİZİNİN YÖNETMENİNİ GİRİN");
                string seriesdirector = Console.ReadLine();
                newLists.Add(new NewList() { Name = seriesname, Type = seriestype, Director = seriesdirector });
               
                Console.ResetColor() ;
            }
            else if (answer == "hayır")
            {
                Console.WriteLine("Çıkış yapılıyor");
            }

            else
            {
                goto Başla;
            }
            Console.WriteLine("BAŞKA DİZİ OLUŞTURMAK İSTER MİSİNİZ");
            string answer2 = Console.ReadLine();
            answer2 = answer2.ToLower();
            if (answer2 == "evet")
            {
                goto Orta;
            }
         
            Console.WriteLine("Yeni Liste");
            Console.ForegroundColor = ConsoleColor.Green;
            var yeniliste = from NewList in newLists
                            orderby NewList.Director
                            orderby NewList.Name
                            select NewList;
            foreach (var difference in yeniliste)
            {
                Console.WriteLine($"Dizinin Adı : {difference.Name}  Dizinin Yönetmeni: {difference.Director}  Dizinin Türü: {difference.Type}");
            }

            Console.ReadKey();
        }
    }
}
