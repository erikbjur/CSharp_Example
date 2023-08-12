using System;

namespace Hello_World;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Console.WriteLine("Press enter to count to 10");

        Console.ReadKey();

        for( int i = 0; i < 10+1; i++) {
            Console.WriteLine(i);
        }
    }
}
