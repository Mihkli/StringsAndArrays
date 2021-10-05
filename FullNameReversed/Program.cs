using System;

namespace FullNameReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi:");
            string lastname = Console.ReadLine();


            for (int i = firstName.Length - 1; i >= 0; i--)
            {
                Console.Write(firstName[i]);    
            }
            Console.WriteLine();
            for(int i = lastname.Length - 1; i >= 0; i--)
            {
                Console.Write(lastname[i]);
            }

            

        }
    }
}
