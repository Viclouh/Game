using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Classes
{
    class Person
    {
        private Inventory inventory = new Inventory(32);

        public Inventory Inventory
        { get => inventory; }
        public Weapon Weapon { get; set; }
        public Armor Armor { get; set; }

        //public void Equip(Weapon weapon)
        //{
        //    if (Inventory.Items.Contains(weapon))
        //    {
        //        Inventory.Items.Remove(weapon);
        //    }
        //    if (Weapon != null)
        //    {
        //        Inventory.Items.Add(Weapon); 
        //    }
        //    Weapon = weapon;
        //}

        //public void Equip(Armor armor)
        //{
        //    if (Inventory.Items.Contains(armor))
        //    {
        //        Inventory.Items.Remove(armor);
        //    }
        //    if (Armor != null)
        //    {
        //        Inventory.Items.Add(Armor); 
        //    }
        //    Armor = armor;
        //}
        public void Equip<T>(T item , Inventory inventory) where T : Item
        {
            
            if (item is Weapon weapon && inventory.Items.Contains(item))
            {
                
                if (Weapon != null)
                {
                    inventory.Items.Add(Weapon); 
                }
                Weapon = weapon;
                inventory.Items.Remove(item);
                return;
            }
            if (item is Armor armor && inventory.Items.Contains(item))
            {
                if (Armor != null)
                {
                    inventory.Items.Add(Armor); 
                }
                Armor = armor;
                inventory.Items.Remove(item);
                return;
            }
        }

    }
}
