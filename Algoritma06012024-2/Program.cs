using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma06012024_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Bir isim yarıştırma oyununda kullanıcıdan 3 adet isim alınıyor bu isimlerden hangisinde en çok karakter var ise o isim kazanıyor
             * Bunu sağlayan metodun algoritması
             */

            /* 1. void isimYaristir(string[] isimler)
             * 2. kazananIsim = isimler[0]
             * 3. int i = 1; i < isimler.Length; i++
             * 4. isimler[i].Length > kazananIsim.Length
             * 5. kazananIsim = isimler[i]
             * 6. 4. basamaktaki mantıksal kod bloğu bitti
             * 7. 3. basamaktaki döngü bloğu bitti
             * 8. çıktı kazananIsim
             */

                string[] isimler = new string[3];

                // Kullanıcıdan 3 isim alınıyor
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("Lütfen isim girin: ");
                    isimler[i] = Console.ReadLine();
                }

                // isimYaristir metodunu çağırıyoruz
                IsimYaristir(isimler);
        }

            // isimYaristir metodu
            static void IsimYaristir(string[] isimler) // 1. void isimYaristir(string[] isimler)
            {
                // 2. kazananIsim = isimler[0]
                string kazananIsim = isimler[0];

                // 3. int i = 1; i < isimler.Length; i++
                for (int i = 1; i < isimler.Length; i++)
                {
                    // 4. isimler[i].Length > kazananIsim.Length
                    if (isimler[i].Length > kazananIsim.Length)
                    {
                        // 5. kazananIsim = isimler[i]
                        kazananIsim = isimler[i];
                    }
                    // 6. 4. basamaktaki mantıksal kod bloğu bitti
                }
                // 7. 3. basamaktaki döngü bloğu bitti

                // 8. çıktı kazananIsim
                Console.WriteLine("En uzun isim: " + kazananIsim);
                Console.ReadKey();
            }
        }

    }

