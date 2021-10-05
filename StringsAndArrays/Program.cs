using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma nimi:");
            string userFirstname = Console.ReadLine();
            Console.WriteLine($"Sinu nimi on {userFirstname.Length} sümbolit pikk");


        }
    }
}
