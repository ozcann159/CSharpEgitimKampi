﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            //Console.WriteLine("**** Yemek Kategorileri ****");
            //Console.WriteLine();
            //Console.WriteLine("1- Çorbalar");
            //Console.WriteLine("2- Ana Yemekler");
            //Console.WriteLine("3- Soğuk Başlangıçlar");
            //Console.WriteLine("4- Salatalar");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("6- İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("**** Yemek Kategorileri ****");
            //#endregion YazdırmaKomutları

            
            //String
            //Degisken_türü degisken_adi

            //string name;
            //name = "Elif";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 555 888 77 77";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadiköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezercasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + customerSurname);
            //Console.WriteLine("İletişim : " + customerPhone);
            //Console.WriteLine("Email Adresi " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("--------------------------------");

            //Console.WriteLine();

            //customerName = "Aysegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 440 300 70 80";
            //customerEmail = "@test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";
            //Console.WriteLine(customerName);
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + customerSurname);
            //Console.WriteLine("İletişim : " + customerPhone);
            //Console.WriteLine("Email Adresi " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("--------------------------------");

             #endregion

            #region int Degiskenler
            int number = 24;
            Console.WriteLine(number);
            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("*****Restorant Menü Fiyatı****");
            Console.WriteLine();
            Console.WriteLine("----Hamburger Fiyat : " + hamburgerPrice + "TL");
            Console.WriteLine("----Pizza : " + pizzaPrice + "TL");
            Console.WriteLine("----Limonata : " + lemonadePrice + "TL");
            Console.WriteLine("----Kızartma : " + friesPrice + "TL");
            Console.WriteLine("----Su : " + waterPrice + "TL");
            Console.WriteLine("----Kola : " + cokePrice + "TL");
            Console.WriteLine("*****Restorant Menü Fiyatı****");


            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 3;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            Console.WriteLine("---------------------------------");
            Console.WriteLine( "Hamburger Tutarı : " + totalHamburgerPrice + "TL");
            Console.WriteLine("Pizza Tutarı : " + totalPizzaPrice + "TL");
            Console.WriteLine("Kızartma Tutarı : " + totalFriesPrice + "TL");
            Console.WriteLine("Su Tutarı : " + totalWaterPrice + "TL");
            Console.WriteLine("Limonata Tutarı : " + totalLemonadePrice + "TL");

            Console.WriteLine();

            int totalPrice = totalCokePrice + totalWaterPrice + totalLemonadePrice + totalFriesPrice + totalHamburgerPrice + totalHamburgerPrice;
            Console.WriteLine("Toplam ödenecek tutar: " + totalPrice + "TL");

            #endregion
            Console.Read();
        }
    }
}
