using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Lütfen bir sayı giriniz: ");
                int number = Convert.ToInt32(Console.ReadLine()); // Kullanıcıdan sayı girişi alınır

                int square = number * number; // Sayının karesi hesaplanır
                Console.WriteLine("Girdiğiniz sayının karesi: " + square);
            }
            catch (FormatException)
            {
                // Geçersiz giriş yapıldığında hata mesajı gösterilir
                Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
            }
            Console.ReadKey();
        }
    }
}
