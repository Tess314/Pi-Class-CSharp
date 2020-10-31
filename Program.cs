using System;

namespace Pi
{
    class Program
    {
        static void Main(string[] args)
        {
            Pi p = new Pi();
            p.PiCalc();
            p.Display();
            p.SaveImage();
            Console.ReadLine();

        }
    }
}
