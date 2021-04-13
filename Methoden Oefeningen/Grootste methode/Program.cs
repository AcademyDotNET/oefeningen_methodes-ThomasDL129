using System;

namespace Grootste_methode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GrootsteGetal(4, 9, 13));
            Console.WriteLine(GrootsteGetal(6, 2, 4));
            Console.WriteLine(GrootsteGetal(8, 12, 6));
        }

        public static int GrootsteGetal(int getal1, int getal2, int getal3)
        {
            int grootste = getal1;
            if (getal1 < getal2)
            {
                grootste = getal2;
                if (getal2 < getal3)
                {
                    grootste = getal3;
                }
                return grootste;
            }
            else if (getal1 < getal3)
            {
                grootste = getal3;
            }
            return grootste;
        }
    }
}
