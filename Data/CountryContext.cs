using Country.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

public class CountryContext : DbContext
{
    public CountryContext(DbContextOptions options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<City>().Property(m => m.CityId).IsRequired();

        builder.Entity<Province>().Property(p => p.ProvinceCode).IsRequired();

        builder.Entity<Province>().ToTable("Province");
        builder.Entity<City>().ToTable("City");

        builder.Seed();
    }
    public DbSet<Province> Provinces { get; set; }
    public DbSet<City> Cities { get; set; }
}