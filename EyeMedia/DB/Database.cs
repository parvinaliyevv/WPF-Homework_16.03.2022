using System.Collections.Generic;
using EyeMedia.Models;

namespace EyeMedia.DB
{
    public class Database
    {
        public Dictionary<ItemLayout, KeyValuePair<int, int>> ItemLayoutSizes { get; set; }


        public Database()
        {
            ItemLayoutSizes = new(3);

            ItemLayoutSizes.Add(ItemLayout.Tile, new(150, 150));
            ItemLayoutSizes.Add(ItemLayout.SmallIcon, new(50, 50));
            ItemLayoutSizes.Add(ItemLayout.Detail, new(50, 50));
        }
    }
}
