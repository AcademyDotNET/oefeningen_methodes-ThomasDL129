using System;

namespace Intro_methode
{
    class Program
    {
        static void Main(string[] args)
        {
            MyIntro();
            MyIntro("Jos", 34, "Trammezantlei 21");
        }

        public static void MyIntro(string naam = "Thomas", int leeftijd = 18, string adres = "Bosstraat 60")
        {
            Console.WriteLine($"Ik ben {naam}, ik ben {leeftijd} jaar oud en woon in de {adres}.");
        }
    }
}
