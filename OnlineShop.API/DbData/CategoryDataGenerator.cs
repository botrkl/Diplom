using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.API.Entities;

namespace OnlineShop.API.DbData
{
    public static class CategoryDataGenerator
    {
        public static readonly List<Category> categories = new List<Category>
        {
            new() 
            { 
                Id = Guid.Parse("946A0305-470A-461A-87E3-8FD62C6DC115"), 
                Name = "Електроніка" 
            },
            new() 
            { 
                Id = Guid.Parse("A7A0B109-23EC-4AF2-AD2C-4149A5888082"), 
                Name = "Книги" 
            },
            new() 
            { 
                Id = Guid.Parse("96CCF359-94B9-4FAD-A857-6FD2E4C6519F"), 
                Name = "Спорт та відпочинок" 
            }
        };

        public static void Generate(ModelBuilder builder)
        {
            builder.Entity<Category>()
                .HasData(categories);
        }
    }
}
