using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class ItemInBox
    {
        public int Id {  get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public ItemInBox(int id, int quantity)
        {
            Id = id; 
            Quantity = quantity;
        }
    }
}
