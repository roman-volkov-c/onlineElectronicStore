using System;

namespace OnlineElectronicsStore.Data
{
    public class SearchService
    {
        public readonly GroupOfProducts[] GroupsOfItems =
        {
            new()
            {
                Name = "компьютеры",
                PathToImage = "Catalogs/Computers/Computer.jpg",
                Products = new GroupOfProducts.Product[]
                {
                    new()
                    {
                        Name = "компьютер1"
                    },
                    new()
                    {
                        Name = "компьютер2"
                    }
                }
            },
            new()
            {
                Name = "ноутбуки",
                PathToImage = "Catalogs/Notebooks/Notebook.jpg"
            },
            new()
            {
                Name = "планшеты",
                PathToImage = "Catalogs/Tablets/Tablet.jpg"
            },
            new()
            {
                Name = "телефоны",
                PathToImage = "Catalogs/Smartphones/Smartphone.jpg"
            },
            new()
            {
                Name = "консоли",
                PathToImage = "Catalogs/Consoles/Console.jpg"
            },
            new()
            {
                Name = "мониторы",
                PathToImage = "Catalogs/Monitors/Monitor.jpg"
            }
        };
    }

    public class ProductCard
    {
        public string Name { get; init; } = string.Empty;
        public string Description { get; init; } = string.Empty;
        public string PathToImage { get; init; } = string.Empty;
    }

    public class GroupOfProducts : ProductCard
    {
        public class Product : ProductCard
        {

        }

        public GroupOfProducts() => Description = "Текст";
        public Product[] Products { get; init; } = Array.Empty<Product>();
    }
}
