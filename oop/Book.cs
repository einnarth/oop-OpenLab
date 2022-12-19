using System;
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
        

        public string TitleM
        {
            get => _title;
            set => _title = value;
        }

        public int PagesM
        {
            get => _pages;
            set => _pages = value < 0 ? 1 : value;
        }

        public string CategoryM
        {
            get => _category;
            set => _category = value;

        }

        public string AuthorM
        {
            get => _author;
           set => _author = value;
        }

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


        public void Information()
        {
            Console.WriteLine($"Nazov: {_title}");
            Console.WriteLine($"Pocet stran { _pages}");
            Console.WriteLine($"Kategória {_category}");
            Console.WriteLine($"Autor: {_author}");
            Console.WriteLine($"Dátum vydania {_relaseDate}");
        }

        public Book()
        {
            _title = "-1";
            _pages = -1;
            _category = "-1";
            _author = "-1";
            _relaseDate = -1;
        }

        public Book(string title, int pages)
        {
            _title = title;
            _pages = pages;
            _category = "-1";
            _author = "-1";
            _relaseDate = -1; 
        }

        public Book(string title, int pages, string category, string author, int relaseDate)
        {
            _title = title;
            _pages = pages;
            _category = category;
            _author = author;
            _relaseDate = relaseDate;
        }
    }
}