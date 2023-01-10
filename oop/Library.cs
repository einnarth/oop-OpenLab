using System.Collections.Generic;


namespace oop
{
    public class Library
    {
        public int NumberOfBooks { get; set; } = 0;
        public int NumberOfStudents { get; set; } = 0;
        public List<string> StudentsList { get; set; } = new List<string>();
        public List<Book> BooksList { get; set; } = new List<Book>();

        public override string ToString()
        {
            string students = null;
            string books = null;

            foreach (var product in StudentsList)
            {
                students = string.Format("{0} {1}", students, product);
            }

            foreach (var product in BooksList)
            {
                books = string.Format("{0} {1}", books, product);
            }

            return string.Format(
                $"Počet študentov{NumberOfStudents} zoznam študentov {students}, počet kníh {NumberOfBooks} zoznam kníh {books}");
        }
        



    }

}