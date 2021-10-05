using System;

namespace ACharacterCounter
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

            /*foreach (char character in fullname)
            {
                if(character == 'a')
                {
                    counter++;
                }
                
            }*/

            /*int i = fullname.Length-1;
            while(i >= 0)
            {
                Console.WriteLine(fullname[i]);
                if(fullname[i] == 'a')
                {
                    counter++;
                }
                i--;
            }*/

            for(int i = 0; i < fullname.Length; i++)
            {
                if(fullname[i] == 'a')
                {
                    counter++;
                }

            }

            Console.WriteLine($"Sinu nimes on {counter} a-tähte");
            

        }
    }
}
