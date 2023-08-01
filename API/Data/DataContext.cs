
using API.Entitites;
using Microsoft.EntityFrameworkCore;


namespace API.Data
{
    public class DataContext : DbContext
    {
        /*
        Constructor.
        In order to make this available to ne injected so we can use 
        the class functionality we need to go to the program.cs file 
        */
        public DataContext(DbContextOptions options) : base(options){

        }

        /*
        Db sets represent tables in our data base.
        Table name will be users and cols will have ID.
        Right click on AppUser and go to def to see 
        */
        public DbSet<AppUser> Users {get; set;}
    }
}