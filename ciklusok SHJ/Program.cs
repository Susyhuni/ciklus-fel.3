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
            Random rand = new Random();
            List<int> szamok = new List<int>();

            for (int i = 0; i < 50; i++)
            {
                szamok.Add(rand.Next(1, 101));
            }


            int osszeg = szamok.Sum();
            Console.WriteLine($"\nÖsszeg: {osszeg}");




            double atlag = szamok.Average();
            Console.WriteLine($"Átlag: {atlag:F2}");

            int max = szamok.Max();
            Console.WriteLine($"Legnagyobb: {max}");

            int min = szamok.Min();
            Console.WriteLine($"Legkisebb: {min}");
            
            Console.WriteLine("kilépéshez valamit");
                Console.ReadLine();





            }
        }
    }

