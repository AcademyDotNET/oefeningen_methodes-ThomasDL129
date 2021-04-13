using System;

namespace Passwoord_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validInput;
            int lengte;

            Console.WriteLine("Voer in hoe lang het paswoord moet zijn:");
            do
            {
                validInput = int.TryParse(Console.ReadLine(), out lengte);
            } while (!validInput);

            GenereerPaswoord(lengte);
            Console.ReadLine();
        }

        private static void GenereerPaswoord(int lengte)
        {
            Random rand = new();
            Console.WriteLine("\nPaswoord:");
            for(int i = 1; i <= lengte; i++)
            {
                int soort = rand.Next(0, 3);
                char teken;
                switch (soort)
                {
                    case 0:
                        teken = Convert.ToChar(rand.Next(48, 58));
                        break;
                    case 1:
                        teken = Convert.ToChar(rand.Next(65, 91));
                        break;
                    case 2:
                        teken = Convert.ToChar(rand.Next(97, 123));
                        break;
                    default:
                        teken = '0';
                        break;
                }
                Console.Write($"{teken}");
            }
        }
    }
}
