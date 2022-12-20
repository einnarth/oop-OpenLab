using System;
using System.Collections.Generic;
using System.Linq;


namespace oop
{
    public class Book
    {
        private string _title;
        private int _pages;
        private string _category;
        private string _author;
        private int _relaseDate;
        
        /// <summary>
        /// getter, setter for title
        /// </summary>
        public string TitleM
        {
            get => _title;
            set => _title = value;
        }
        /// <summary>
        /// getter, setter for pages
        /// </summary>
        public int PagesM
        {
            get => _pages;
            set => _pages = value < 0 ? 1 : value;
        }
        /// <summary>
        /// setter for category
        /// </summary>
        public string CategoryM
        {
            set => _category = value;
        }
        /// <summary>
        /// getter,setter for author
        /// </summary>
        public string AuthorM
        {
            get => _author;
           set => _author = value;
        }
        /// <summary>
        /// getter, setter for relase date
        /// </summary>
        public int RelaseDateM
        {
            get => _relaseDate;
            set
            {
                if (Enumerable.Range(1450, 2021).Contains(value))
                {
                    _relaseDate = value;
                }
                else
                {
                    _relaseDate = -1;
                }
            }
        }

        /// <summary>
        /// Method for writing down the information of the book
        /// </summary>
        public void Information()
        {
            Console.WriteLine($"Nazov: {_title}");
            Console.WriteLine($"Pocet stran { _pages}");
            Console.WriteLine($"Kategória {_category}");
            Console.WriteLine($"Autor: {_author}");
            Console.WriteLine($"Dátum vydania {_relaseDate}");
        }
        /// <summary>
        /// Blank contstructor
        /// </summary>
        public Book()
        {
            _title = "-1";
            _pages = -1;
            _category = "-1";
            _author = "-1";
            _relaseDate = -1;
        }
        /// <summary>
        /// constructor that sets values to title and pages
        /// </summary>
        /// <param name="title"></param>
        /// <param name="pages"></param>
        public Book(string title, int pages)
        {
            _title = title;
            _pages = pages;
            _category = "-1";
            _author = "-1";
            _relaseDate = -1; 
        }
        /// <summary>
        /// constructor that sets every value for Book
        /// </summary>
        /// <param name="title"></param>
        /// <param name="pages"></param>
        /// <param name="category"></param>
        /// <param name="author"></param>
        /// <param name="relaseDate"></param>
        public Book(string title, int pages, string category, string author, int relaseDate)
        {
            _title = title;
            _pages = pages;
            _category = category;
            _author = author;
            _relaseDate = relaseDate;
        }
        /// <summary>
        /// List of categories
        /// </summary>
        public static List<string> CategoryList = new List<string>()
            { "detské", "romantické", "náučné", "sci-fi", "dobrodružné" };
    }
}