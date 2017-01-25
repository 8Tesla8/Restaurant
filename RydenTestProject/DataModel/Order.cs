using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RydenTestProject.DataModel
{
    public class Order
    {
        public int Id { set; get; }
        public DateTime Day { set; get; }
        public TimeSpan DinerStartTime { set; get; }
        public TimeSpan DinerEndTime { set; get; } //PayTime
        public bool IsPayed { set; get; }
        public string CreditCard { get; set; }

        public Employee Waiter { get; set; }

        public Client Client { get; set; }

        public ICollection<Dish> Dishes { get; set; }

        public int Table { get; set; }
    }
}
