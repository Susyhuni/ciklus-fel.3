using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciklusok_SHJ
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> szamok = new List<int>();

            for (int i = 0; i < 50; i++)
            {
                szamok.Add(rnd.Next(1, 101));
            }

            int össz = 0;
            int max = szamok[0];
            int min = szamok[0];
            bool több5 = false;
            int több90 = 0;
            List<int> több90szam = new List<int>();

            for (int i = 0; i < szamok.Count; i++)
            {
                int szam = szamok[i];
                össz += szam;

                if (szam > max)
                    max = szam;

                if (szam < min)
                    min = szam;

                if (szam < 5)
                    több5 = true;

                if (szam > 90)
                {
                    több90++;
                    több90szam.Add(szam);
                }
            }

            double average = (double)össz / szamok.Count;

            Console.WriteLine("Összeg: " + össz);
            Console.WriteLine("Átlag: " + average);
            Console.WriteLine("Legnagyobb elem: " + max);
            Console.WriteLine("Legkisebb elem: " + min);
            Console.WriteLine("Van 5-nél kisebb érték? " + (több5 ? "Igen" : "Nincs"));
            Console.WriteLine("90-nél nagyobb számok száma: " + több90);

            if (több90 > 0)
            {
                Console.WriteLine("90-nél nagyobb számok:");
                for (int i = 0; i < több90szam.Count; i++)
                {
                    Console.Write(több90szam[i] + " ");
                }
                Console.WriteLine();

                Console.WriteLine("valamit kilépéshez");
                Console.ReadLine();
            }
        }
    }
}

