using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Classes
{
    class Inventory
    {
        public Inventory(int capacity)
        {
            items = new List<Item>(capacity);
        }


        private List<Item> items;
        public List<Item> Items { get => items; }


        public List<Item> SortByNameInventory(string name)
        {
            return Items.OrderBy(p => p.Name).ToList();
        }
        public List<Item> SortByWeightInventory(uint weight)
        {
            return Items.OrderBy(p => p.Weight).ToList();
        }
        public List<Item> SortByPriceInventory(uint price)
        {
            return Items.OrderBy(p => p.Price).ToList();
        }
        public List<Item> SearchItem(string name)
        {
            return Items.Where(p => p.Name.ToLower().Contains(name.ToLower())).ToList();
        }
        public List<T> Filter<T>() 
        {
            return Items.OfType<T>().ToList();
        }
    }
}
