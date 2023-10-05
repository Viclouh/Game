using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Classes
{
     class Armor : Item
    {
        public int Defence { get; set; }
        public Armor(string name,uint price,uint weight, int defence) : base( name,price,weight)
        {
            Defence = defence;
        }
    }
}
