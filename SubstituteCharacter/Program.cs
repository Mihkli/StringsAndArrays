﻿using System;

namespace SubstituteCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi:");
            string lastname = Console.ReadLine();
            string fullname = firstName + lastname.ToLower();
            int counter = 0;

            for(int i = 0; i < fullname.Length; i++)
            {
                if (fullname[i] == 'a')
                {
                    fullname[i] = "*";
                }
            }
        }
    }
}
