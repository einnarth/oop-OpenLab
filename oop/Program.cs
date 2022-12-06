
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
            
            
        }
        
    }
}
