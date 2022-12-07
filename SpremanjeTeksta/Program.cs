using System;
using System.IO;
namespace SpremanjeTeksta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite ime: ");
            string ime = Console.ReadLine();
            Console.Write("Unesite prezime: ");
            string prezime = Console.ReadLine();
            StreamWriter sw = new StreamWriter(@"C:\Users\ucenik\Documents\LukaRadetic\datoteka.txt");
            sw.WriteLine("Ime: {0}", ime);
            sw.WriteLine("Prezime: {0}", prezime);
            sw.Close();
        }
    }
}