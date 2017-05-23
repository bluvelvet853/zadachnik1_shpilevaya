using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha9_legko
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] massiv = new int[5, 6];
            Random ran = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    massiv[i, j] = ran.Next(1, 10);
                    Console.Write("{0}\t", massiv[i, j]);
                }
            }
            int stroka = 0, stolbec = 0, summa = 0, summa1 = 0, minimum = 0, maximum = 0, sredneearif = 0;
            for (int j = 0; j < 6; j++)
            {
                summa = 0;
                for (int i = 0; i < 5; i++)
                {
                    summa += massiv[i, j];
                    if (i == 4)
                    {
                        sredneearif = summa / 5;
                    }
                }
                stolbec = stolbec + 1;
                Console.WriteLine("\r\n Сумма {0} столбца = {1}", stolbec, summa);
                Console.WriteLine("\r\n Среднее арифметическое {0} столбца = {1}", stolbec, sredneearif);
            }
         

            int c = 0;
            for (int i = 0; i < 5; i++)
            {
                summa = 0;
                for (int j = 0; j < 6; j++)
                {
                    summa += massiv[i, j];
                    if (summa >= summa1)
                    {
                        maximum = summa;
                        c = i + 1;
                    }
                    else
                    {
                        maximum = summa1;
                    }
                }
                summa1 = maximum;
                stroka = stroka + 1;
                Console.WriteLine("\r\n Сумма {0} строки = {1}", stroka, summa);
            }
            Console.WriteLine("\r\n Строкой с максимальной суммой является {0} строка, ее сумма равна {1}", c, summa1);

            for (int i = 0; i < 5; i++)
            {
                summa = 0;
                for (int j = 0; j < 6; j++)
                {
                    summa += massiv[i, j];
                    if (i == 0)
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
            }
            Console.WriteLine("\r\n Минимальная сумма строки равна {0}", summa1);
            Console.ReadKey();         
        }
    }
}
