using Microsoft.EntityFrameworkCore;
using OnlineStore.DAL.Entities;

namespace OnlineStore.DAL.DbData
{
    public static class DbProductImagesGenerator
    {
        private static readonly List<ProductImage> Products = new List<ProductImage>
    {
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[0].Id,
            Url = "https://content.rozetka.com.ua/goods/images/big/37399230.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[0].Id,
            Url = "https://content1.rozetka.com.ua/goods/images/big/37399239.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[0].Id,
            Url = "https://content1.rozetka.com.ua/goods/images/big/37399245.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[1].Id,
            Url = "https://content1.rozetka.com.ua/goods/images/big/364834253.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[1].Id,
            Url = "https://content.rozetka.com.ua/goods/images/big/364834255.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[1].Id,
            Url = "https://content2.rozetka.com.ua/goods/images/big/364834254.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[2].Id,
            Url = "https://content1.rozetka.com.ua/goods/images/big/221214136.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[2].Id,
            Url = "https://content.rozetka.com.ua/goods/images/big/221214137.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[2].Id,
            Url = "https://content2.rozetka.com.ua/goods/images/big/221214138.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[3].Id,
            Url = "https://content2.rozetka.com.ua/goods/images/big/328132329.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[3].Id,
            Url = "https://content2.rozetka.com.ua/goods/images/big/328132330.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[3].Id,
            Url = "https://content1.rozetka.com.ua/goods/images/big/328132333.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[4].Id,
            Url = "https://content2.rozetka.com.ua/goods/images/big/310655416.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[4].Id,
            Url = "https://content.rozetka.com.ua/goods/images/big/310655419.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[4].Id,
            Url = "https://content2.rozetka.com.ua/goods/images/big/310655427.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[5].Id,
            Url = "https://content.rozetka.com.ua/goods/images/big/364852941.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[5].Id,
            Url = "https://content2.rozetka.com.ua/goods/images/big/364852943.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[6].Id,
            Url = "https://content.rozetka.com.ua/goods/images/big/353760041.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[6].Id,
            Url = "https://content.rozetka.com.ua/goods/images/big/353760042.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[6].Id,
            Url = "https://content2.rozetka.com.ua/goods/images/big/353760043.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[7].Id,
            Url = "https://content1.rozetka.com.ua/goods/images/big/412885389.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[7].Id,
            Url = "https://content.rozetka.com.ua/goods/images/big/412885391.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[7].Id,
            Url = "https://content1.rozetka.com.ua/goods/images/big/412885394.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[7].Id,
            Url = "https://content2.rozetka.com.ua/goods/images/big/412885396.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[8].Id,
            Url = "https://content2.rozetka.com.ua/goods/images/big/398539813.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[8].Id,
            Url = "https://content1.rozetka.com.ua/goods/images/big/398539816.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[9].Id,
            Url = "https://content2.rozetka.com.ua/goods/images/big/365162840.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[9].Id,
            Url = "https://content.rozetka.com.ua/goods/images/big/365162842.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[9].Id,
            Url = "https://content2.rozetka.com.ua/goods/images/big/365162844.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[10].Id,
            Url = "https://content1.rozetka.com.ua/goods/images/big/371935662.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[10].Id,
            Url = "https://content2.rozetka.com.ua/goods/images/big/371935667.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[10].Id,
            Url = "https://content1.rozetka.com.ua/goods/images/big/371935679.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[11].Id,
            Url = "https://content1.rozetka.com.ua/goods/images/big/394186890.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[11].Id,
            Url = "https://content.rozetka.com.ua/goods/images/big/394186893.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[11].Id,
            Url = "https://content1.rozetka.com.ua/goods/images/big/394186900.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[12].Id,
            Url = "https://content.rozetka.com.ua/goods/images/big/358606821.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[12].Id,
            Url = "https://content2.rozetka.com.ua/goods/images/big/358606827.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[12].Id,
            Url = "https://content2.rozetka.com.ua/goods/images/big/358606835.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[13].Id,
            Url = "https://content1.rozetka.com.ua/goods/images/big/419197501.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            ProductId = DbProductsGenerator.Products[13].Id,
            Url = "https://content1.rozetka.com.ua/goods/images/big/419197503.jpg"
        }
    };

        public static void Generate(ModelBuilder builder)
        {
            builder.Entity<ProductImage>()
                .HasData(Products);
        }
    }
}