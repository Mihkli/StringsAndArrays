using System;

namespace FullName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi:");
            string lastname = Console.ReadLine();
            
            if(firstName.Length < lastname.Length)
            {
                Console.WriteLine($"Sinu perekonnanimel on {lastname.Length - firstName.Length} sümbolit rohkem kui eesnimel");
            }   
            else if(lastname.Length < firstName.Length)
            {
                Console.WriteLine($"Sinu eesnimel on {firstName.Length - lastname.Length} sümbolit rohkem kui perekonnanimel");

            }
            else
            {
                Console.WriteLine("Sama pikad");
            }

        }
    }
}
