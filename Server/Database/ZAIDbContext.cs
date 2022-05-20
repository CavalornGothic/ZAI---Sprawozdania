using Microsoft.EntityFrameworkCore;
using ZAI.Shared.Database;

namespace ZAI.Server.Database;
public class ZAIDbContext : DbContext
{
    public DbSet<AddressessEntity> Adressess { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<RoleLinks> RolesLinks { get; set; }
    public DbSet<Token> Tokens { get; set; }

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

        modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Login = "user", PasswordHash = BCrypt.Net.BCrypt.HashPassword("user")}
                , new User { Id = 2, Login = "arek", PasswordHash = BCrypt.Net.BCrypt.HashPassword("arek") }
                , new User { Id = 3, Login = "user3", PasswordHash = BCrypt.Net.BCrypt.HashPassword("user3") }
            );
        modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "User"},
                new Role { Id = 2, Name = "Administrator"},
                new Role { Id = 3, Name = "DataBrowsing" },
                new Role { Id = 4, Name = "DataEditing" },
                new Role { Id = 5, Name = "UserEditing" }
            );

        modelBuilder.Entity<RoleLinks>().HasData(
                new RoleLinks { Id = 1, RoleID = 1, UserID = 1},
                new RoleLinks { Id = 2, RoleID = 2, UserID = 2},
                new RoleLinks { Id = 3, RoleID = 1, UserID = 3},
                new RoleLinks { Id = 4, RoleID = 2, UserID = 3},
                // data browsing
                new RoleLinks { Id = 5, RoleID = 3, UserID = 1 },
                new RoleLinks { Id = 6, RoleID = 3, UserID = 2 },
                new RoleLinks { Id = 7, RoleID = 3, UserID = 3 },
                 // data editing
                new RoleLinks { Id = 8, RoleID = 4, UserID = 2 },
                // data editing oraz user editing dla user nr 3
                new RoleLinks { Id = 9, RoleID = 4, UserID = 3 },
                new RoleLinks { Id = 10, RoleID = 5, UserID = 3 }
            );
    }
}
