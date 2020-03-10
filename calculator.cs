using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi kalkulator";

            //int a = 10;
            //int b = 6;

            Console.WriteLine("Pilih menu kalkulator :");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            Console.WriteLine();

            Console.WriteLine("Input nomor menu : ");
            int pil = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Masukan nilai a = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Masukan nilai b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            switch (pil)
            {
                case 1:
                    Console.WriteLine("Hasil Penambahan" + a + "+" + b + " = " + Penambahan(a, b));
                    break;
                case 2:
                    Console.WriteLine("Hasil Pengurangan" + a + "-" + b + " = " + Pengurangan(a, b));
                    break;
                case 3:
                    Console.WriteLine("Hasil Perkalian" + a + "*" + b + " = " + Perkalian(a, b));
                    break;
                case 4:
                    Console.WriteLine("Hasil Pembagian" + a + "/" + b + " = " + Pembagian(a, b));
                    break;
                case 5:
                    Console.WriteLine("Maaf,menu tidak tersedia");
                    break;
                default:
                    break;
            }



            Console.WriteLine();

            //Console.WriteLine("Hasil Penambahan" + a + "+" + b + "=" + Penambahan(a , b));
            //Console.WriteLine("Hasil Pengurangan" + a + "-" + b + "=" + Pengurangan(a , b));
            //Console.WriteLine("Hasil Perkalian" + a + "*" + b + "=" + Perkalian(a , b));
            //Console.WriteLine("Hasil Pembagian" + a + "/" + b + "=" + Pembagian(a , b));

            Console.WriteLine("\nPress any button to exit :) ");
            Console.ReadKey();
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
