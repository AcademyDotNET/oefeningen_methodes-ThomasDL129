using System;

namespace Methoden_Oefeningen
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validInput;
            bool quit = false;
            do
            {
                PrintMenu();
                validInput = int.TryParse(Console.ReadLine(), out int keuze);

                switch (keuze)
                {
                    case 1:
                        Kwadraat();
                        break;
                    case 2:
                        BerekenStraal();
                        break;
                    case 3:
                        BerekenOmtrekCirkel();
                        break;
                    case 4:
                        BerekenOppervlakteCirkel();
                        break;
                    case 5:
                        GrootsteGetal();
                        break;
                    case 6:
                        IsEven();
                        break;
                    case 7:
                        IsArmstrong();
                        break;
                    case 8:
                        OnevenNummers();
                        break;
                    case 9:
                        ArmstrongNummers();
                        break;
                    case 0:
                        quit = true;
                        break;
                    default:
                        break;
                }
            } while (!validInput || !quit && validInput);
        }

        private static void ArmstrongNummers()
        {
            PrintAmstringNummersPrompt();
            double n = InputCheckDouble();
            ToonArmstrongNummers(n);
            Console.ReadLine();
        }

        private static void ToonArmstrongNummers(double n)
        {
            for(int i = 1; i <= n; i++)
            {
                if (IsArmstrongBerekenen(i))
                {
                    Console.Write($"{i}, ");
                }
            }
        }

        private static void PrintAmstringNummersPrompt()
        {
            Console.Clear();
            Console.WriteLine("Geef een getal op en de console zal alle Armstrong nummers geven van 1 tot de invoer.");
        }

        private static void OnevenNummers()
        {
            PrintToonOnevenNummersPrompt();
            double n = InputCheckDouble();
            ToonOnevenNummers(n);
            Console.ReadLine();
        }

        private static void ToonOnevenNummers(double n)
        {
            for(int i = 1; i <= n; i += 2)
            {
                Console.Write($"{i}, ");
            }
        }

        private static void PrintToonOnevenNummersPrompt()
        {
            Console.Clear();
            Console.WriteLine("Geef een getal op en de console zal alle oneven nummers geven van 1 tot de invoer.");
        }

        private static void IsArmstrong()
        {
            PrintIsArmstrong();
            double n = InputCheckDouble();
            bool isArmstrong = IsArmstrongBerekenen(n);

            if (isArmstrong)
            {
                Console.WriteLine($"{n} is een Armstrong getal");
            }
            else
            {
                Console.WriteLine($"{n} is niet een Armstrong getal");
            }
            Console.ReadLine();
        }

        private static bool IsArmstrongBerekenen(double n)
        {
            string strGetal = n.ToString();
            double totaal = 0;
            foreach(char element in strGetal)
            {
                totaal += Math.Pow(Char.GetNumericValue(element), strGetal.Length);
            }

            if(totaal == n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void PrintIsArmstrong()
        {
            Console.Clear();
            Console.WriteLine("Geef een getal om te weten of het een Armstrong getal is.");
        }

        private static void IsEven()
        {
            PrintIsEvenPrompt();
            double n = InputCheckDouble();
            bool isEven = IsEvenBerekenen(n);
            if (isEven)
            {
                Console.WriteLine($"{n} is een even getal");
            }
            else
            {
                Console.WriteLine($"{n} is een even getal");
            }
            Console.ReadLine();
        }

        private static bool IsEvenBerekenen(double n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void PrintIsEvenPrompt()
        {
            Console.Clear();
            Console.WriteLine("Geef een getal om te weten of het een even getal is.");
        }

        private static void GrootsteGetal()
        {
            PrintGrootsteGetalPrompt();
            double n = InputCheckDouble();
            Console.WriteLine("Nu het tweede getal.");
            double m = InputCheckDouble();
            GrootsteGetalBerekenen(n, m);
            Console.ReadLine();
        }

        private static void GrootsteGetalBerekenen(double n, double m)
        {
            if(n > m)
            {
                Console.WriteLine($"{n} is groter dan {m}.");
            }
            else if (m > n)
            {
                Console.WriteLine($"{m} is groter dan {n}.");
            }
            else
            {
                Console.WriteLine("De twee getallen zijn gelijk aan elkaar.");
            }
        }

        private static void PrintGrootsteGetalPrompt()
        {
            Console.Clear();
            Console.WriteLine("Geef twee getallen in om te weten welk het grootste is.");
        }

        private static void BerekenOppervlakteCirkel()
        {
            PrintBerekenOppervlakteCirkelPrompt();
            double n = InputCheckDouble();
            Console.WriteLine($"De oppervlakte van een cirkel met diameter {n} bedraagt {Math.Round(Math.Pow(n, 2) * Math.PI / 4, 3, MidpointRounding.AwayFromZero)}");
            Console.ReadLine();
        }

        private static void PrintBerekenOppervlakteCirkelPrompt()
        {
            Console.Clear();
            Console.WriteLine("Geef een diameter van een cirkel om de oppervlakte te berekenen.");
        }

        private static void BerekenOmtrekCirkel()
        {
            PrintBerekenOmtrekCirkelPrompt();
            double n = InputCheckDouble();
            Console.WriteLine($"De omtrek van een cirkel met diameter {n} bedraagt {Math.Round(n * Math.PI, 3, MidpointRounding.AwayFromZero)}");
            Console.ReadLine();
        }

        private static void PrintBerekenOmtrekCirkelPrompt()
        {
            Console.Clear();
            Console.WriteLine("Geef een diameter van een cirkel om de omtrek te berekenen.");
        }

        private static void PrintBerekenStraalPrompt()
        {
            Console.Clear();
            Console.WriteLine("Geef een diameter van een cirkel om de straal te berekenen.");
        }

        private static void BerekenStraal()
        {
            PrintBerekenStraalPrompt();
            double n = InputCheckDouble();
            Console.WriteLine($"De straal bedraagt {n / 2}.");
            Console.ReadLine();
        }

        private static void Kwadraat()
        {
            PrintKwadraatPrompt();
            double n = InputCheckDouble();

            Console.WriteLine($"Het kwadraat van {n} is {Math.Pow(n, 2)}");
            Console.ReadLine();
        }

        private static void PrintKwadraatPrompt()
        {
            Console.Clear();
            Console.WriteLine("Geef een nummer op die je wil kwadrateren.");
        }

        private static double InputCheckDouble()
        {
            bool validInput;
            double n;
            do
            {
                validInput = double.TryParse(Console.ReadLine(), out n);
                if (!validInput)
                {
                    Console.WriteLine(">Foute invoer.");
                }
            } while (!validInput);

            return n;
        }

        private static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine($"Welke functie wil je gebruiken?");
            Console.WriteLine($"1) Kwadraat");
            Console.WriteLine($"2) Straal van een cirkel");
            Console.WriteLine($"3) Omtrek van een cirkel");
            Console.WriteLine($"4) Oppervlakte van een cirkel");
            Console.WriteLine($"5) Grootste getal");
            Console.WriteLine($"6) Even getal");
            Console.WriteLine($"7) Armstrong getal");
            Console.WriteLine($"8) Oneven getallen");
            Console.WriteLine($"9) Armstrong getallen");
            Console.WriteLine($"0) Sluiten");
        }
    }
}
