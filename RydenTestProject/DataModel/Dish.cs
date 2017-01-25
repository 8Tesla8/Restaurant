using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RydenTestProject.DataModel
{
    public class Dish //can be a drink
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public double Measurement { get; set; }

        public DishType DishType { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
