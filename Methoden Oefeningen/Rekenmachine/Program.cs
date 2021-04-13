using System;

namespace Rekenmachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double uitkomst = 0;

            do
            {
                input = Console.ReadLine();
                if (input.Contains('+'))
                {
                    uitkomst = TelOp(input);
                }
                else if (input.Contains('-'))
                {
                    uitkomst = TrekAf(input);
                }
                else if (input.Contains('*'))
                {
                    uitkomst = Vermenigvuldig(input);
                }
                else if (input.Contains('/'))
                {
                    uitkomst = DeelDoor(input);
                }
                Console.WriteLine($"= {uitkomst}\n");
            } while (input != "off");
        }

        private static double TelOp(string input)
        {
            double uitkomst;
            string[] getallen = input.Split('+');
            uitkomst = Convert.ToDouble(getallen[0]) + Convert.ToDouble(getallen[1]);

            return uitkomst;
        }

        private static double TrekAf(string input)
        {
            double uitkomst;
            string[] getallen = input.Split('-');
            uitkomst = Convert.ToDouble(getallen[0]) - Convert.ToDouble(getallen[1]);

            return uitkomst;
        }

        private static double Vermenigvuldig(string input)
        {
            double uitkomst;
            string[] getallen = input.Split('*');
            uitkomst = Convert.ToDouble(getallen[0]) * Convert.ToDouble(getallen[1]);

            return uitkomst;
        }

        private static double DeelDoor(string input)
        {
            double uitkomst;
            string[] getallen = input.Split('/');
            uitkomst = Convert.ToDouble(getallen[0]) / Convert.ToDouble(getallen[1]);

            return uitkomst;
        }
    }
}
