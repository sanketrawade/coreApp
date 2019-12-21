using coreApp.Models;
using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
    /*public DataContext() : base(GetOptions(""))
    {

    }
    private static DbContextOptions GetOptions(string connectionString)
    {
        return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
    }*/
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=HP-PC\SQLEXPRESS;Database=MyShop-Core;Trusted_Connection=True;");
    }

    public DbSet<Product> products { get; set; }

}