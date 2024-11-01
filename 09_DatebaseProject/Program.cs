﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatebaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ado.net

            Console.WriteLine("***** C# Ürün - Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();


            string tableNumber;


            Console.WriteLine("------------------------------------");
            Console.WriteLine("1- Kategoriler");
            Console.WriteLine("2- Ürünüler");
            Console.WriteLine("3- Siparişler");
            Console.WriteLine("4- Çıkış Yap");
            Console.WriteLine("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");

            tableNumber = Console.ReadLine();
            Console.WriteLine("------------------------------------");

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-IK2SQI5\\SQLEXPRESS; Initial Catalog=EgitimKampiDb; Integrated Security=True");

            connection.Open();

            SqlCommand command = new SqlCommand("Select * from TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }

            Console.Read();
        }

        
    }
}
