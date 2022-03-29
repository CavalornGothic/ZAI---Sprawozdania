using Microsoft.EntityFrameworkCore;

namespace ZAI.Server.Database;
public class ZAIDbContext : DbContext
{
    public DbSet<AddressessEntity> Adressess { get; set; }

    public ZAIDbContext(DbContextOptions options) : base(options) 
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AddressessEntity>().HasData(
                new AddressessEntity {Id = 1, Address = "Słoneczna 1", City = "Poznań", Province = "Wielkopolskie", District = "Poznańskie", ZipCode = "60-001" },
                new AddressessEntity { Id = 2, Address = "Makowa 5C", City = "Poznań", Province = "Wielkopolskie", District = "Poznańskie", ZipCode = "60-001" },
                new AddressessEntity { Id = 3, Address = "Piaskowa 1b", City = "Poznań", Province = "Wielkopolskie", District = "Poznańskie", ZipCode = "60-001" },
                new AddressessEntity { Id = 4, Address = "Pythonowa 16", City = "Poznań", Province = "Wielkopolskie", District = "Poznańskie", ZipCode = "60-001" },
                new AddressessEntity { Id = 5, Address = "Javascriptowa 1", City = "Poznań", Province = "Wielkopolskie", District = "Poznańskie", ZipCode = "60-001" },
                new AddressessEntity { Id = 6, Address = "Hakerska 21/37", City = "Poznań", Province = "Wielkopolskie", District = "Poznańskie", ZipCode = "60-001" },
                new AddressessEntity { Id = 7, Address = "Drewniana 9/2", City = "Poznań", Province = "Wielkopolskie", District = "Poznańskie", ZipCode = "60-001" },
                new AddressessEntity { Id = 8, Address = "Gruszkowa 4", City = "Poznań", Province = "Wielkopolskie", District = "Poznańskie", ZipCode = "60-001" },
                new AddressessEntity { Id = 9, Address = "Humusowa 18", City = "Poznań", Province = "Wielkopolskie", District = "Poznańskie", ZipCode = "60-001" },
                new AddressessEntity { Id = 10, Address = "Jana Wazy 13", City = "Poznań", Province = "Wielkopolskie", District = "Poznańskie", ZipCode = "60-001" }
            );
    }
}
