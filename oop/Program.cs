
using System;
using Microsoft.VisualBasic;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Book lotr = new Book();
            lotr.TitleM("miskociganko"); 
            lotr.PagesM(153);
            lotr.CategoryM("fantasy");
            lotr.AuthorM("michal bernat");
            lotr.RelaseDateM("06/06/2012");
            lotr.Information();
            
            
        }
        
    }
}
