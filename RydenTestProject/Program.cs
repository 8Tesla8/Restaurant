using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RydenTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            using (RestaurantDb db = new RestaurantDb())
            {
                  var clients = db.Clients.ToList();
            }
        }
    }
}
