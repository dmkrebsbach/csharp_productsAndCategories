using Microsoft.EntityFrameworkCore;

namespace productsAndCategories.Models //change projectName to the name of project
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products {get;set;} // needs one line for each Model.cs file created, 
        public DbSet<Category> Categories {get;set;}
        public DbSet<Association> Associations {get;set;}                                       //User is Model Name, Users is the Db Property & Table Name
    }
}