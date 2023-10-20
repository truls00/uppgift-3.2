using System;
namespace uppgift_3._2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("har du gått ut gymnsaiumet");
            string x = (string)Console.ReadLine();
            if (x=="j")
            {

            }
            string z = (string)Console.ReadLine();
            if (z=="n")
            {

            }
            Console.WriteLine("hur gammal är du ");
            int y = int.Parse(Console.ReadLine());
            if (y < 22)
            {
                Console.WriteLine("du får jobb");
            }
            int a = int.Parse(Console.ReadLine());
            if (a>22)
            {
                Console.WriteLine("du får inte jobb");
            }
        }
    }
}

