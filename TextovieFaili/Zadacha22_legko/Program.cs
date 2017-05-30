using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha22_legko
{
    class Program
    {
        struct Plastinki
        {
            public string singer;
            public int zhanr;
            public string nazvanie;
            public int tirazh;
        }
        static void Main(string[] args)
        {
        string text = System.IO.File.ReadAllText(@"C:\Users\black\Desktop\Ученый.txt");
            string[] plastinki = text.Split(new char[] { ':' });

            Plastinki[] plastinkiMas = new Plastinki[plastinki.Length];
            for (int i = 0; i < plastinki.Length - 1; i++)
            {
                string[] a = plastinki[i].Split(new char[] { ';' });
                plastinkiMas[i].singer = a[0];
                plastinkiMas[i].zhanr = a[1];
                plastinkiMas[i].nazvanie = a[2];
                plastinkiMas[i].tirazh = Convert.ToInt32(a[3]);

                if (plastinkiMas[i].tirazh > 10000)
                {
                    Console.WriteLine("Исполнитель: {0}\r\n Жанр: {1}\r\n Название: {2}\r\n Тираж: {3}\r\n", plastinkiMas[i].singer, plastinkiMas[i].zhanr = a[1], plastinkiMas[i].nazvanie = a[2], plastinkiMas[i].tirazh = Convert.ToInt32(a[3]));
                }
                Console.ReadLine();
            }
        }
    }
}
