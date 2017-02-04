using System;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            // We can just simply define our values at the time of initalisation which is much cleaner!
            Movie goodMovie = new Movie("Silence of the Lambs", "Jonathon Demme", 1991, 19000000);
            Movie anotherGoodMovie = new Movie("Red Dragon", "Brett Ratner", 2002, 78000000);
        }
    }

    class Movie
    {
        // We can define a new class and its elements rather than specifying them each time
        public string Name { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public int Budget { get; set; }

        // We can also define a constructor in order to initialise our object from the start rather than manually setting each element after an instance is created
        public Movie(string name, string director, int year, int budget)
        {
            Name = name;
            Director = director;
            Year = year;
            Budget = budget;
        }
    }
}
