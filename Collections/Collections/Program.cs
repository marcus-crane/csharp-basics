using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            Language language1 = new Language();
            language1.ID = "1";
            language1.Name = "C#";
            language1.LatestStableVersion = "6.0";
            language1.ReleaseYear = 2000;

            Language language2 = new Language();
            language2.ID = "2";
            language2.Name = "C++";
            language2.LatestStableVersion = "2.4.0";
            language2.ReleaseYear = 1995;

            Book book1 = new Book();
            book1.Title = "C# Programming Yellow Book";
            book1.Author = "Rob Miles";
            book1.ISBN = "978-1509301157";

            /*
             * Old style of collections
             * They're dynamically sized, allow sorting etc
             * Allowed adding of any class which, if I tried to add a book, would say it couldn't cast a book into a language
             * However, the languages themselves would still print until it hit book and then throw an exception
             

            ArrayList arrayList = new ArrayList();
            arrayList.Add(language1);
            arrayList.Add(language2);

            foreach(Language language in arrayList)
            {
                Output.PrintLanguages(language.Name, language.ReleaseYear, language.LatestStableVersion);
            }
            */

            /*
             * List based collection
             
            List<Language> list = new List<Language>();
            list.Add(language1);
            list.Add(language2);
            // What if we try to add a book?
            // list.Add(book1);
            // VS states cannot convert Collections.Book => Collections.Language before the application is even run

            foreach(Language language in list)
            {
                Output.PrintLanguages(language.Name, language.ReleaseYear, language.LatestStableVersion);
            }

            */

            // Dictionary Collection

            // Create a dictionary that accepts a string (in this case ID) and then a language object
            Dictionary<string, Language> dictionary = new Dictionary<string, Language>();

            // Adding languages with their respective ID as the key
            dictionary.Add(language1.ID, language1);
            dictionary.Add(language2.ID, language2);

            // Fetch C++ by its ID (a string of 2) Apparently the key needs to always be a string?
            Console.WriteLine(dictionary["2"].Name);
            
            Console.ReadKey();

        }
    }

    class Language
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public string LatestStableVersion { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }

    class Output
    {
        public static void PrintLanguages(string name, int year, string version)
        {
            Console.WriteLine("{0} first released in {1} and is now at Version {2}", name, year, version);
        }
    }
}
