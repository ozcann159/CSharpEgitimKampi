using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If
            //Console.Write("Lütfen Şifreyi Giriniz:");
            //string password;
            //password= Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru");
            //}
            //else {
            //    Console.WriteLine("Şifre yanlış");
            //}

            string capital, country;
            Console.WriteLine("Başkenti giriniz: ");
            capital = Console.ReadLine();

            Console.Write("Ülkeyi giriniz: ");
            country = Console.ReadLine();

            if (capital == "ankara" & country == "türkiye")
            {
                Console.WriteLine("Veriler doğrulandı");
            }
            else
            {
                Console.WriteLine("Veriler hatalı");
            }

            #endregion
            #region

            #endregion
            Console.Read();
        }
    }
}
