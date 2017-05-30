using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha9_legko
{
    class Program
    {
        struct VScena
        {
            public string naimenovanie;
            public int kolichestvo;
            public string cena;
            public int proizvoditel;
            public string data_postupleniya_na_sklad;
        }
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\black\Desktop\Strukturi9.txt");
            string[] massiv = text.Split(new char[] { ':' });
            VScena[] newmassiv = new VScena[massiv.Length];
            for (int i = 0; i < massiv.Length - 1; i++)
            {
                string[] a = massiv[i].Split(new char[] { ',' });
                newmassiv[i].naimenovanie = a[0];
                newmassiv[i].kolichestvo = Convert.ToInt32(a[1]);
                newmassiv[i].cena = Convert.ToInt32(a[2]);
                newmassiv[i].proizvoditel = a[3];
                newmassiv[i].data_postupleniya_na_sklad = Convert.ToInt32(a[4]);



                {

                    Console.WriteLine("Фамилия: {0}\r\n Дата Рождения: {1}\r\n Должность: {2}\r\n Зарплата: {3}\r\n Образование: {4}\r\n", newmassiv[i].naimenovanie = a[0], newmassiv[i].kolichestvo = Convert.ToInt32(a[1]), newmassiv[i].cena = Convert.ToInt32(a[2]), newmassiv[i].proizvoditel = a[3], newmassiv[i].data_postupleniya_na_sklad = Convert.ToInt32(a[4]));
                    Console.WriteLine();
                }

            }
        }
    }
}
