using System;

namespace Pi
{
    class Pi
    {
        private double pi;
        private string temp;
        private string digits;

        public void PiCalc()
        {
            pi = Math.PI;
            temp = pi.ToString();
            digits = temp.Substring(2);
        }

        public void Display()
        {
            Console.WriteLine("Pi: " + pi);
            Console.WriteLine("Digits (after decimal point): " + (digits.Length));
        }
    }
}
