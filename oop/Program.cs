
namespace oop
{
    static class Program
    {
        static void Main(string[] args)
        {
            Book lotr = new Book
            {
                TitleM = "miskociganko",
                PagesM = 153,
                CategoryM = "fantasy",
                AuthorM = "michal bernat",
                RelaseDateM = 2012
            };
            lotr.Information();
            Book lotr2 = new Book();
            lotr2.Information();
            Book lotr3 = new Book("Pán Prsteňov: Návrat Kráľa", 170);
            lotr3.Information();
            Book hobbit = new Book("Hobbit", 370, "fantasy novel", "J.R.R Tolkien", 1937)
            {
                CategoryM = Book.CategoryList[4 + 3]
            };
            hobbit.Information();


        }
        
    }
}
