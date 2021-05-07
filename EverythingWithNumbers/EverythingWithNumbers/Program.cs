using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace sorular
{
    class Program
    {
        static void Main(string[] args)



        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Kaç sayı gireceksiniz?");

            int boyut = int.Parse(Console.ReadLine());
            ArrayList sayilar = new ArrayList();
            int s;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sayı giriniz:");

            for (int i = 0; i < boyut; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                s = int.Parse(Console.ReadLine());
                sayilar.Add(s);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Girilen sayıların listelenmiş hali=");
            foreach (var item in sayilar)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(" "+item );
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nGirilen sayılar arasında 3'e veya 7'ye tam bölünenler:");

            int y = 0;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n3'e bolünenler=\n");
            foreach (int item in sayilar)
            {
                if (item % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("\n"+item);
                    y++;
                }
             
            }
            int z= 0;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n7'e bolünenler= \n");
            foreach (int item in sayilar)
            {
                if (item % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(item+"\n");
                    z++;
                }

            }

            if (y == 0)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nGirilen sayılar arasında 3'e bölünen sayı yoktur!");
            }

            if (z == 0)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Girilen sayılar arasında  7'ye bölünen sayı yoktur!");
            }


            if (y == 0&&z==0)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Girilen sayılar arasında 3'e veya 7'ye bölünen sayı yoktur!");
            }



            sayilar.Sort();

            object enbuyuk = sayilar[boyut - 1];
            object enkucuk = sayilar[0];
            int fark = (int)enbuyuk - (int)enkucuk;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nEn büyük ile En küçük arasındaki fark = " + fark);

            int toplam = 0;
            for (int i = 0; i < boyut; i++)
            {
                toplam += (int)sayilar[i];
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Dizinin içindeki sayıların ortalaması = " + (toplam / sayilar.Count));


            int sayaç = 0;
            foreach (int item in sayilar)

            {

                if (item > 0 && item % 2 == 0)
                {
                    sayaç++;


                }
               
            }
            if (sayaç == 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Girilen sayılar arasında pozitif sayı yoktur!");
            }



            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Dizinin içerisindeki pozitif çift sayıların adedi " + sayaç + " tanedir.");





            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Dizi içerisindeki negatif tek sayılar = ");
            int x = 0;
            foreach (int item in sayilar)
            {
              
                if (item < 0 && item % 2 != 0)
                {

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(item + " ");
                    x++;
                }

            }

            if (x == 0)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Girilen sayılar arasında negatif tek sayı yoktur!");

            }

            Console.ReadKey();

        }
    }

}
