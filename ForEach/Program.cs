using System;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloword = "Hello World!";
            int counter = 0;
            foreach(char character in helloword)
            {
                counter = counter + 1;
                //counter++;
            }
            Console.WriteLine($"{helloword} on {counter} sümbolit pikk.");

        }
    }
}
