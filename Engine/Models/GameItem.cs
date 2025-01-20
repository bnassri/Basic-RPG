using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class GameItem
    {
        public int ItemTypeID { get; }
        public string Name { get; }
        public string Price { get; }
        public GameItem(int itemTypeID, string name, string price)
        {
            ItemTypeID = itemTypeID;
            Name = name;
            Price = price;
        }

        public GameItem Clone()
        {
            return new GameItem(ItemTypeID, Name, Price);
        }
    }
}
