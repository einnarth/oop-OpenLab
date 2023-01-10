
using System;

namespace oop
{
    static class Program
    {
        static void Main(string[] args)
        {
            var slovenskýJazyk = new Book("Slovenský Jazyk", 193);
            var matematika = new Book("Matematika", 23);
            var fyzika = new Book("Fyzika",55);
            var elektronika = new Book("Elektronika", 532);
            var schoolLibrary = new Library();
            {
                schoolLibrary.StudentsList.Add("John");
                schoolLibrary.StudentsList.Add("Poul");
                schoolLibrary.BooksList.Add(slovenskýJazyk);
                schoolLibrary.BooksList.Add(matematika);
                schoolLibrary.BooksList.Add(fyzika);
                schoolLibrary.BooksList.Add(elektronika);
                schoolLibrary.NumberOfBooks = 4;
                schoolLibrary.NumberOfStudents = 2;
            }

            Console.WriteLine(schoolLibrary.ToString());
        }
        
    }
}
