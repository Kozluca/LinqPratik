using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPratik
{
    internal class Program
    {
        static void Main(string[] args)


        {
            /*
                Rastgele 10 adet sayıdan oluşan bir liste oluşturunuz. Bu liste üzerinden aşağıdaki linq sorgularını çalıştırarak konsol ekranına istenilenleri yazdırınız.

                    Çift olan sayılar

                    Tek olan sayılar

                    Negatif sayılar

                    Pozitif Sayılar

                    15'ten büyük ve 22'den küçük sayılar

                Listedeki her bir sayının karesi (Bunun için yeni bir liste oluşturup yazdırabilirsiniz.)
               
              */
            List<int> numbers = new List<int> { -2, 5, -4, 9, 3, 25, 0, 18, -7, 17 }; //  numbers adında liste oluşturduk
            var evennumbers = numbers.Where(num => num % 2 == 0);                     // Linq sorgularını çalıştırarak  Çift olan sayıların şartını yazdık
            Console.WriteLine(" Çift olan sayılar ");
            foreach (var num in evennumbers)                                            // foreach ile ekrana yazdırdık
            {
                Console.WriteLine(num);
            }

            Console.WriteLine(" Tek olan sayılar ");
            List<int> numbers1 = new List<int> { -2, 5, -4, 9, 3, 25, 0, 18, -7, 17 };      //  numbers1 adında liste oluşturduk
            evennumbers = numbers1.Where(num => num % 2 != 0);                              // Linq sorgularını çalıştırarak  Tek olan sayıların şartını yazdık
            foreach (var singlenum in evennumbers)                                            // foreach ile ekrana yazdırdık
            {
                Console.WriteLine(singlenum);
            }

            Console.WriteLine(" Negatif sayılar ");
            List<int> numbers2 = new List<int> { -2, 5, -4, 9, 3, 25, 0, 18, -7, 17 };
            var numberss = numbers2.Where(num => num < 0);                                      // Linq sorgularını çalıştırarak  Negatif olan sayıların şartını yazdık
            foreach (var negativenumbers in numberss)
            {
                Console.WriteLine(negativenumbers);
            }

            Console.WriteLine("Pozitif Sayılar");
            List<int> numbers3 = new List<int> { -2, 5, -4, 9, 3, 25, 0, 18, -7, 17 };
            var possitivenumbers = numbers.Where(num => num > -1);                              // Linq sorgularını çalıştırarak  Pozitif olan sayıların şartını yazdık
            foreach (var positive in possitivenumbers)
            {
                Console.WriteLine(positive);
            }

            Console.WriteLine(" 15'ten büyük ve 22'den küçük sayılar");
            List<int> numbers4 = new List<int> { -2, 5, -4, 9, 3, 25, 0, 18, -7, 17 };
            var BetweenNumbers = numbers4.Where(num => num > 15).Where(num => num < 22);        // Linq sorgularını çalıştırarak   15'ten büyük ve 22'den küçük olan sayıların şartını yazdık
            foreach (var between in BetweenNumbers)
            {
                Console.WriteLine(between);
            }
            Console.ReadKey();
        }
    }
}
