using System;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie goodMovie = new Movie();
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
