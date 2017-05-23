using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha19_legko
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\black\Desktop\Ученый.txt");
            string[] mus = text.Split('.');
            for (int i = 0; i < mus.Length; i++)
            {
                string[] muss = mus[i].Split(new char[] { ';' });
                if (muss[6].StartsWith("кандидат технических наук"))
                {
                    Console.WriteLine("Фамилия: {0}\r\n Имя: {1}\r\n  Отчество: {2}\r\n Пол: {3}\r\n Национальность: {4}\r\n Дата рождения: {5}\r\n Ученая степень, должность, номер телефона: {6}\r\n Домашний адрес: {7}", muss[0], muss[1], muss[2], muss[3], muss[4], muss[5], muss[6], muss[7]);
                }
            }
            Console.ReadKey();
        }
    }
}
