using System;

namespace oop
{
    public class Book
    {
        private string _title;
        private int _pages;
        private string _category;
        private string _author;
        private string _relaseDate;

        public void TitleM(string tit)
        {
            _title = tit;
        }

        public void PagesM(int page)
        {
            _pages = page;
        }

        public void CategoryM(string cat)
        {
            _category = cat;
        }

        public void AuthorM(string aut)
        {
            _author = aut;
        }

        public void RelaseDateM(string relase)
        {
            _relaseDate = relase;
        }

        public void Information()
        {
            Console.WriteLine("Názov: " + _title);
            Console.WriteLine("Počet strán " + _pages);
            Console.WriteLine("Kategória " + _category);
            Console.WriteLine("Autor: " + _author);
            Console.WriteLine("Dátum vydania " + _relaseDate);
            
        }
     
    }
}