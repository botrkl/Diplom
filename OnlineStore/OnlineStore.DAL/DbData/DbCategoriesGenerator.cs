using Microsoft.EntityFrameworkCore;
using OnlineStore.DAL.Entities;

namespace OnlineStore.DAL.DbData
{
    public static class DbCategoriesGenerator
    {
        private static readonly List<Category> Categories = new List<Category>
    {
        new ()
        {
            Id = new Guid("7f319f69-85dd-4923-ac9f-5acd0b2a1b39"),
            Name = "Electronics",
            ParentCategoryId = null,
        },
        new ()
        {
            Id = new Guid("a1b2c3d4-95f6-4d3c-8b7a-6f594d3c2b1a"),
            Name = "Smartphones",
            ParentCategoryId = new Guid("7f319f69-85dd-4923-ac9f-5acd0b2a1b39"),
        },
        new ()
        {
            Id = new Guid("b1a2c3d4-95f6-4d3c-8b7a-6f594d3c2b1a"),
            Name = "Apple",
            ParentCategoryId = new Guid("a1b2c3d4-95f6-4d3c-8b7a-6f594d3c2b1a"),
        },
        new ()
        {
            Id = new Guid("91a2b3d4-95f6-4d3c-8b7a-6f594d3c2b1a"),
            Name = "Samsung",
            ParentCategoryId = new Guid("a1b2c3d4-95f6-4d3c-8b7a-6f594d3c2b1a"),
        },
        new ()
        {
            Id = new Guid("91a2b3c4-95f6-4d3c-8b7a-6f594d3c2b1a"),
            Name = "Gadgets",
            ParentCategoryId = new Guid("7f319f69-85dd-4923-ac9f-5acd0b2a1b39"),
        },
        new ()
        {
            Id = new Guid("71a2b3c4-95f6-4d3c-8b7a-6f594d3c2b1a"),
            Name = "Smartwatches",
            ParentCategoryId = new Guid("91a2b3c4-95f6-4d3c-8b7a-6f594d3c2b1a")
        },
        new ()
        {
            Id = new Guid("81a2b3c4-95f6-4d3c-8b7a-6f594d3c2b1a"),
            Name = "Fitness Trackers",
            ParentCategoryId = new Guid("91a2b3c4-95f6-4d3c-8b7a-6f594d3c2b1a")
        },
        new ()
        {
            Id = new Guid("6f319f69-85dd-4923-ac9f-5acd0b2a1b39"),
            Name = "Clothing",
            ParentCategoryId = null,
        },
        new ()
        {
            Id = new Guid("7f319f69-85dd-4923-ac9f-5acd0b2a1b40"),
            Name = "Men's Clothing",
            ParentCategoryId = new Guid("6f319f69-85dd-4923-ac9f-5acd0b2a1b39")
        },
        new ()
        {
            Id = new Guid("7f319f69-85dd-4923-ac9f-5acd0b2a1b41"),
            Name = "Women's Clothing",
            ParentCategoryId = new Guid("6f319f69-85dd-4923-ac9f-5acd0b2a1b39")
        },
        new ()
        {
            Id = new Guid("7f319f69-85dd-4923-ac9f-5acd0b2a1b42"),
            Name = "Kids' Clothing",
            ParentCategoryId = new Guid("6f319f69-85dd-4923-ac9f-5acd0b2a1b39")
        }
    };

        public static void Generate(ModelBuilder builder)
        {
            builder.Entity<Category>()
                .HasData(Categories);
        }
    }
}