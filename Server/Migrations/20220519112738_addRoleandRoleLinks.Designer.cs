// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZAI.Server.Database;

#nullable disable

namespace ZAI.Server.Migrations
{
    [DbContext(typeof(ZAIDbContext))]
    [Migration("20220519112738_addRoleandRoleLinks")]
    partial class addRoleandRoleLinks
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("ZAI.Shared.Database.AddressessEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Adressess");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Słoneczna 1",
                            City = "Poznań",
                            District = "Poznańskie",
                            Province = "Wielkopolskie",
                            ZipCode = "60-001"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Makowa 5C",
                            City = "Poznań",
                            District = "Poznańskie",
                            Province = "Wielkopolskie",
                            ZipCode = "60-001"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Piaskowa 1b",
                            City = "Poznań",
                            District = "Poznańskie",
                            Province = "Wielkopolskie",
                            ZipCode = "60-001"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Pythonowa 16",
                            City = "Poznań",
                            District = "Poznańskie",
                            Province = "Wielkopolskie",
                            ZipCode = "60-001"
                        },
                        new
                        {
                            Id = 5,
                            Address = "Javascriptowa 1",
                            City = "Poznań",
                            District = "Poznańskie",
                            Province = "Wielkopolskie",
                            ZipCode = "60-001"
                        },
                        new
                        {
                            Id = 6,
                            Address = "Hakerska 21/37",
                            City = "Poznań",
                            District = "Poznańskie",
                            Province = "Wielkopolskie",
                            ZipCode = "60-001"
                        },
                        new
                        {
                            Id = 7,
                            Address = "Drewniana 9/2",
                            City = "Poznań",
                            District = "Poznańskie",
                            Province = "Wielkopolskie",
                            ZipCode = "60-001"
                        },
                        new
                        {
                            Id = 8,
                            Address = "Gruszkowa 4",
                            City = "Poznań",
                            District = "Poznańskie",
                            Province = "Wielkopolskie",
                            ZipCode = "60-001"
                        },
                        new
                        {
                            Id = 9,
                            Address = "Humusowa 18",
                            City = "Poznań",
                            District = "Poznańskie",
                            Province = "Wielkopolskie",
                            ZipCode = "60-001"
                        },
                        new
                        {
                            Id = 10,
                            Address = "Jana Wazy 13",
                            City = "Poznań",
                            District = "Poznańskie",
                            Province = "Wielkopolskie",
                            ZipCode = "60-001"
                        });
                });

            modelBuilder.Entity("ZAI.Shared.Database.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "User"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Administrator"
                        },
                        new
                        {
                            Id = 3,
                            Name = "DataBrowsing"
                        },
                        new
                        {
                            Id = 4,
                            Name = "DataEditing"
                        },
                        new
                        {
                            Id = 5,
                            Name = "UserEditing"
                        });
                });

            modelBuilder.Entity("ZAI.Shared.Database.RoleLinks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoleID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserID")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RoleID");

                    b.HasIndex("UserID");

                    b.ToTable("RolesLinks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RoleID = 1,
                            UserID = 1
                        },
                        new
                        {
                            Id = 2,
                            RoleID = 2,
                            UserID = 2
                        },
                        new
                        {
                            Id = 3,
                            RoleID = 1,
                            UserID = 3
                        },
                        new
                        {
                            Id = 4,
                            RoleID = 2,
                            UserID = 3
                        },
                        new
                        {
                            Id = 5,
                            RoleID = 3,
                            UserID = 1
                        },
                        new
                        {
                            Id = 6,
                            RoleID = 3,
                            UserID = 2
                        },
                        new
                        {
                            Id = 7,
                            RoleID = 3,
                            UserID = 3
                        },
                        new
                        {
                            Id = 8,
                            RoleID = 4,
                            UserID = 2
                        },
                        new
                        {
                            Id = 9,
                            RoleID = 4,
                            UserID = 3
                        },
                        new
                        {
                            Id = 10,
                            RoleID = 5,
                            UserID = 3
                        });
                });

            modelBuilder.Entity("ZAI.Shared.Database.Token", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BrowserAgent")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Expired")
                        .HasColumnType("TEXT");

                    b.Property<string>("IP")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsCanceled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Start")
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserID");

                    b.ToTable("Tokens");
                });

            modelBuilder.Entity("ZAI.Shared.Database.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AddTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddTime = new DateTime(2022, 5, 19, 13, 27, 38, 149, DateTimeKind.Local).AddTicks(5644),
                            Login = "user",
                            PasswordHash = "$2a$11$Ze9Ujxqq0KSzJtiJ1HBFj.AcdB.VmZiAYTGZaYreEqPmqST7w/jU."
                        },
                        new
                        {
                            Id = 2,
                            AddTime = new DateTime(2022, 5, 19, 13, 27, 38, 320, DateTimeKind.Local).AddTicks(1793),
                            Login = "arek",
                            PasswordHash = "$2a$11$UDLCR4a1pT79mrRa0saINuMmMLlXUiDWx5n.TgCSsNtjiwKC4IAXW"
                        },
                        new
                        {
                            Id = 3,
                            AddTime = new DateTime(2022, 5, 19, 13, 27, 38, 475, DateTimeKind.Local).AddTicks(9798),
                            Login = "user3",
                            PasswordHash = "$2a$11$bAOUNELSMYDLPA/CXPyOReO6Kfh0cm.O5W4GQHFZ5wUnUvR7jTBfa"
                        });
                });

            modelBuilder.Entity("ZAI.Shared.Database.RoleLinks", b =>
                {
                    b.HasOne("ZAI.Shared.Database.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZAI.Shared.Database.User", "User")
                        .WithMany("RoleUsers")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ZAI.Shared.Database.Token", b =>
                {
                    b.HasOne("ZAI.Shared.Database.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ZAI.Shared.Database.User", b =>
                {
                    b.Navigation("RoleUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
