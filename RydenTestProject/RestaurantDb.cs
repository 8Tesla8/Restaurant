namespace RydenTestProject
{
    using DataModel;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class RestaurantDb : DbContext
    {
         public RestaurantDb()
            : base("name=RestaurantDb")
        {
            Database.SetInitializer<RestaurantDb>(new DropCreateDatabaseAlways<RestaurantDb>());
        }


        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Dish> Dishes { get; set; }
        public virtual DbSet<DishType> DishTypes { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeType> EmployeeTypes { get; set; }
        public virtual DbSet<MeasurementType> MeasurementTypes { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
    }
}