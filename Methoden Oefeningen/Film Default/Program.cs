using System;

namespace Film_Default
{
    class Program
    {
        public enum Genre { Drama, Actie, Onbekend}
        static void Main(string[] args)
        {
            FilmRuntime("The Matrix");
            FilmRuntime("Mulan", 80);
            FilmRuntime("Hot Fuzz", 120, Genre.Actie);
        }

        public static void FilmRuntime(string naam, int duur = 90, Genre genre = Genre.Onbekend)
        {
            Console.WriteLine($"{naam} ({duur}minuten, {genre})");
        }
    }
}
