using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Classes
{
     class Weapon: Item
    {

        public int Damage { get; set; }
        public Weapon(string name, uint price, uint weight, int damage):base(name,price,weight)
        {
            Damage = damage;
        }

    }
}
