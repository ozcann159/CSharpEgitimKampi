﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            #region If Else
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

            //string capital, country;
            //Console.WriteLine("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Veriler doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Bilgi");
            //}

            //int number;
            //Console.Write("Sayıyı Giriniz");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı");
            //}

            #endregion
            #region
            //int exam1, exam2, exam3, average;
            //string result = "Hata";

            //Console.Write("Sınav 1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların ortalaması " + average);


            //if (average > 0 && average <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if (average <50 && average <= 70)
            //{
            //    result = "Sonuç orta";
            //}
            //if (average > 70 && average <= 84)
            //{
            //    result = "Sonuç iyi";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç çok iyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.WriteLine("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}

            //Console.WriteLine("Lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoşgeldiniz");
            //}



            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.WriteLine("Birinci sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("Birinci sayının 2. sayıya bölümünden kalan:  " + result);

            //Console.WriteLine("Lütfen sayıyı giriniz");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir");
            //}

            #endregion

            #region Char degiskenler ile karar yapıları

            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());
            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Beşiktaş");
            //}
            #endregion

            #region Ornek Proje

            //Console.WriteLine("******* C# Eğitim Kampı Restorant *****");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2 - Çorbalar");
            //Console.WriteLine("3 - Pizzalar");
            //Console.WriteLine("4 - İçecekler");
            //Console.WriteLine("5 - Tatlılar");
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();
            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------------Ana Yemekler----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Köri soslu tavuk");
            //    Console.WriteLine("2- Kızartma Tabağı");
            //    Console.WriteLine("3- Fasulye Pilav");
            //    Console.WriteLine("4- Fırında Somon");
            //    Console.WriteLine("5- Patlıcan Musakka");
            //    Console.WriteLine("-----------------Ana Yemekler----------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------------Çorbalar----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Mercimek");
            //    Console.WriteLine("2- Ezogelin Çorba");

            //    Console.WriteLine("-----------------Çorbalar----------------");

            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------------Pizzalar----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Akdeniz Pizza");
            //    Console.WriteLine("2- Margaritha");
            //    Console.WriteLine("3- Tavuklu Pizza");

            //    Console.WriteLine("-----------------Pizzalar----------------");

            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------------İçecekler----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Ayran");
            //    Console.WriteLine("2- Su");
            //    Console.WriteLine("2- Kola");

            //    Console.WriteLine("-----------------İçecekler----------------");

            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------------Tatlılar----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Traliçe");
            //    Console.WriteLine("2- Kazandibi");
            //    Console.WriteLine("3- Sütlaç");

            //    Console.WriteLine("-----------------Tatlılar----------------");

            //    Console.WriteLine();
            //}
            #endregion

            #region Switch Case

            Console.WriteLine("Lütfen ay girişi yapınız: ");
            int monthNumber = int.Parse(Console.ReadLine());

            switch (monthNumber)
            {
                case 1: Console.WriteLine("Ocak"); break;
                case 2: Console.WriteLine("Şubat"); break;
                case 3: Console.WriteLine("Mart"); break;
                case 4: Console.WriteLine("Nisan"); break;
                case 5: Console.WriteLine("Mayıs"); break;
                case 6: Console.WriteLine("Haziran"); break;
                case 7: Console.WriteLine("Temmuz"); break;
                case 8: Console.WriteLine("Ağustos"); break;
                case 9: Console.WriteLine("Eylül"); break;
                case 10: Console.WriteLine("Ekim"); break;
                case 11: Console.WriteLine("Kasım"); break;
                case 12: Console.WriteLine("Aralık"); break;
                default: Console.WriteLine("Hatalı veri girişi"); break;

            }


            #endregion

            #region Switch Case Hesap Makinesi
            //int number1, number2, result;
            //char symbol;

            //Console.Write("Birinci sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("İkinci sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğniiz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;
            //}
            #endregion

            Console.Read();
        }
    } 
}

