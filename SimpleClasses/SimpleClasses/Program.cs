using System;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie favouriteMovie = new Movie();

            favouriteMovie.Name = "Bronson";
            favouriteMovie.Director = "Nicolas Winding Refn";
            favouriteMovie.Year = 2008;
            favouriteMovie.Budget = 230000;

            Console.WriteLine("I can recommend {0} by {1}!\nIt released in {2} and was made on a budget of ${3}.",
                favouriteMovie.Name,
                favouriteMovie.Director,
                favouriteMovie.Year,
                favouriteMovie.Budget
                );

            Console.ReadKey();
        }
    }

    class Movie
    {
        public string Name { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public int Budget { get; set; }
    }
}
