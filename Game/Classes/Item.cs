using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Classes
{
    class Item
    {
        public string Name { get; set; }
        public uint Price { get; set; }
        public uint Weight { get; set; }
        public Item(string name, uint price, uint weight)
        {
            Name = name;
            Price = price;
            Weight = weight;
        }
    }
}
