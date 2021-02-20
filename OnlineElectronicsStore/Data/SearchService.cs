using System;
using System.Collections.Generic;

namespace OnlineElectronicsStore.Data
{
    public class SearchService
    {
        public readonly IEnumerable<GroupOfItems> GroupsOfItems = new GroupOfItems[]
        {
            new()
            {
                Name = "компьютеры",
                PathToImage = "Catalogs/Computers/Computer.jpg",
                Items = new GroupOfItems.Item[]
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

    public interface ICardContent
    {
        string Name { get; init; }
        string Description { get; init; }
        string PathToImage { get; init; }
    }

    public class GroupOfItems : ICardContent
    {
        public class Item : ICardContent
        {
            public string Name { get; init; }
            public string Description { get; init; }
            public string PathToImage { get; init; }
        }

        public string Name { get; init; }
        public string Description { get; init; } = "Текст";
        public string PathToImage { get; init; }
        public IEnumerable<Item> Items { get; init; } = Array.Empty<Item>();
    }
}
