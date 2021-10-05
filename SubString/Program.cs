using System;

namespace SubString
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloworld = "Hello World";
            string PartToLookFor = "hello";
            
            bool isThere;

            isThere = helloworld.ToLower().Contains(PartToLookFor);

            if (isThere)
            {
                Console.WriteLine($"leidisn {PartToLookFor} üles!");
            }
            else
            {
                Console.WriteLine($"Ei leidnud {PartToLookFor}");
            }   
            
        }
    }
}
