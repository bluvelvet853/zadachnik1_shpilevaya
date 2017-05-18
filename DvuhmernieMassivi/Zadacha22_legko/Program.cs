using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha22_legko
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] massiv = new int[5, 10];
            Random ran = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    massiv[i, j] = ran.Next(1, 10);
                    Console.Write("{0}\t", massiv[i, j]);
                }
            }
            int stroka = 0, summa = 0, summa1 = 0, minimum = 0;
            for (int i = 0; i < 5; i++)
            {
                summa = 0;
                for (int j = 0; j < 10; j++)
                {
                    summa += massiv[i, j];
                    if (i == 1)
                    {
                        summa1 = summa;
                    }
                    if (summa > summa1)
                    {
                        minimum = summa1;
                    }
                    else
                    {
                        minimum = summa;
                    }
                }
                summa1 = minimum;
                stroka = stroka + 1;
                Console.WriteLine("\r\n Сумма {0} строки = {1}", stroka, summa);
            }

            Console.WriteLine("\r\n Минимальная сумма строки равна {0}", summa1);
            Console.ReadKey();
        }
    }
}
