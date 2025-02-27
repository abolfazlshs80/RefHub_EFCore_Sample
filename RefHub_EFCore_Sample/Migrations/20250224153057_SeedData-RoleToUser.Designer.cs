﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RefHub_EFCore_Sample.Database.Context;

#nullable disable

namespace RefHub_EFCore_Sample.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250224153057_SeedData-RoleToUser")]
    partial class SeedDataRoleToUser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.Another", b =>
                {
                    b.Property<int>("AnotherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnotherId"));

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.HasKey("AnotherId");

                    b.HasIndex("LanguageId");

                    b.ToTable("Another");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BlogId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<int>("PersonLevelId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BlogId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("PersonLevelId");

                    b.ToTable("Blog");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<int>("PersonLevelId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("PublisherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublisherYear")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("View")
                        .HasColumnType("int");

                    b.HasKey("BookId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("PersonLevelId");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.BookToAnother", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("AnotherId")
                        .HasColumnType("int");

                    b.HasKey("BookId", "AnotherId");

                    b.HasIndex("AnotherId");

                    b.ToTable("BookToAnother");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.HasIndex("LanguageId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Desc = "تمام دسته بندی ها هست",
                            LanguageId = 1,
                            Name = "همه"
                        },
                        new
                        {
                            CategoryId = 2,
                            Desc = "this is a all category",
                            LanguageId = 2,
                            Name = "ALL"
                        });
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.CommentToBlog", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentId"));

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubCommentId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommentId");

                    b.HasIndex("BlogId");

                    b.ToTable("CommentToBlog");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.CommentToBook", b =>
                {
                    b.Property<int>("CommentId")
                        .HasColumnType("int");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubCommentId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommentId");

                    b.ToTable("CommentToBook");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.FileManager", b =>
                {
                    b.Property<int>("FileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FileId"));

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("FileId");

                    b.HasIndex("UserId");

                    b.ToTable("FileManager");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.FileToBlog", b =>
                {
                    b.Property<int>("FileId")
                        .HasColumnType("int");

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.HasKey("FileId", "BlogId");

                    b.HasIndex("BlogId");

                    b.ToTable("FileToBlog");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.FileToBook", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("FileId")
                        .HasColumnType("int");

                    b.HasKey("BookId", "FileId");

                    b.HasIndex("FileId");

                    b.ToTable("FileToBook");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.FileToUser", b =>
                {
                    b.Property<int>("FileId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("FileId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("FileToUser");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.Language", b =>
                {
                    b.Property<int>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LanguageId"));

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LanguageId");

                    b.ToTable("Language");

                    b.HasData(
                        new
                        {
                            LanguageId = 1,
                            DisplayName = "Iran",
                            Name = "fa-IR"
                        },
                        new
                        {
                            LanguageId = 2,
                            DisplayName = "English",
                            Name = "en-US"
                        });
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserAddressId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("UserIdAddress")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("UserAddressId");

                    b.HasIndex("UserId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderItemId"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("OrderItemId");

                    b.HasIndex("BookId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.PersonLevel", b =>
                {
                    b.Property<int>("PersonLevelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonLevelId"));

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonLevelId");

                    b.HasIndex("LanguageId");

                    b.ToTable("PersonLevel");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            Name = "ADMIN"
                        },
                        new
                        {
                            RoleId = 2,
                            Name = "USER"
                        });
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TagId"));

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagId");

                    b.HasIndex("LanguageId");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.TagToBlog", b =>
                {
                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("BlogId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("TagToBlog");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.TagToBook", b =>
                {
                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.HasKey("TagId", "BookId");

                    b.HasIndex("BookId");

                    b.ToTable("TagToBook");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Email = "User@localhost.com",
                            Family = "_User",
                            Name = "User",
                            Password = "123",
                            UserName = "User"
                        },
                        new
                        {
                            UserId = 2,
                            Email = "Admin@localhost.com",
                            Family = "_Admin",
                            Name = "Admin",
                            Password = "123",
                            UserName = "Admin"
                        });
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.UserAddress", b =>
                {
                    b.Property<int>("UserAddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserAddressId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ostan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserAddressId");

                    b.HasIndex("UserId");

                    b.ToTable("UserAddress");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.UserToRole", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("RoleId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserToRole");

                    b.HasData(
                        new
                        {
                            RoleId = 2,
                            UserId = 1
                        },
                        new
                        {
                            RoleId = 1,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.Another", b =>
                {
                    b.HasOne("RefHub_EFCore_Sample.Database.Model.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.Blog", b =>
                {
                    b.HasOne("RefHub_EFCore_Sample.Database.Model.Category", "Category")
                        .WithMany("Blog")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RefHub_EFCore_Sample.Database.Model.Language", "Language")
                        .WithMany("Blog")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RefHub_EFCore_Sample.Database.Model.PersonLevel", "PersonLevel")
                        .WithMany()
                        .HasForeignKey("PersonLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Language");

                    b.Navigation("PersonLevel");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.Book", b =>
                {
                    b.HasOne("RefHub_EFCore_Sample.Database.Model.Category", "Category")
                        .WithMany("Book")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RefHub_EFCore_Sample.Database.Model.Language", "Language")
                        .WithMany("Book")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RefHub_EFCore_Sample.Database.Model.PersonLevel", "PersonLevel")
                        .WithMany("Book")
                        .HasForeignKey("PersonLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Language");

                    b.Navigation("PersonLevel");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.BookToAnother", b =>
                {
                    b.HasOne("RefHub_EFCore_Sample.Database.Model.Another", "Another")
                        .WithMany("BookToAnother")
                        .HasForeignKey("AnotherId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("RefHub_EFCore_Sample.Database.Model.Book", "Book")
                        .WithMany("Another")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Another");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.Category", b =>
                {
                    b.HasOne("RefHub_EFCore_Sample.Database.Model.Language", "Language")
                        .WithMany("Category")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Language");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.CommentToBlog", b =>
                {
                    b.HasOne("RefHub_EFCore_Sample.Database.Model.Blog", "Blog")
                        .WithMany("CommentToBlog")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.CommentToBook", b =>
                {
                    b.HasOne("RefHub_EFCore_Sample.Database.Model.Book", "Book")
                        .WithMany("CommentToBook")
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.FileManager", b =>
                {
                    b.HasOne("RefHub_EFCore_Sample.Database.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.FileToBlog", b =>
                {
                    b.HasOne("RefHub_EFCore_Sample.Database.Model.Blog", "Blog")
                        .WithMany("FileToBlog")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RefHub_EFCore_Sample.Database.Model.FileManager", "FileManager")
                        .WithMany("FileToBlog")
                        .HasForeignKey("FileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");

                    b.Navigation("FileManager");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.FileToBook", b =>
                {
                    b.HasOne("RefHub_EFCore_Sample.Database.Model.Book", "Book")
                        .WithMany("FileToBook")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RefHub_EFCore_Sample.Database.Model.FileManager", "FileManager")
                        .WithMany("FileToBook")
                        .HasForeignKey("FileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("FileManager");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.FileToUser", b =>
                {
                    b.HasOne("RefHub_EFCore_Sample.Database.Model.FileManager", "FileManager")
                        .WithMany("FileToUser")
                        .HasForeignKey("FileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RefHub_EFCore_Sample.Database.Model.User", "User")
                        .WithMany("FileToUser")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("FileManager");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.Order", b =>
                {
                    b.HasOne("RefHub_EFCore_Sample.Database.Model.UserAddress", "UserAddress")
                        .WithMany("Order")
                        .HasForeignKey("UserAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RefHub_EFCore_Sample.Database.Model.User", "User")
                        .WithMany("Order")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("UserAddress");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.OrderItem", b =>
                {
                    b.HasOne("RefHub_EFCore_Sample.Database.Model.Book", "Book")
                        .WithMany("OrderItem")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RefHub_EFCore_Sample.Database.Model.Order", "Order")
                        .WithMany("OrderItem")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.PersonLevel", b =>
                {
                    b.HasOne("RefHub_EFCore_Sample.Database.Model.Language", "Language")
                        .WithMany("PersonLevel")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Language");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.Tag", b =>
                {
                    b.HasOne("RefHub_EFCore_Sample.Database.Model.Language", "Language")
                        .WithMany("Tag")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.TagToBlog", b =>
                {
                    b.HasOne("RefHub_EFCore_Sample.Database.Model.Blog", "Blog")
                        .WithMany()
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RefHub_EFCore_Sample.Database.Model.Tag", "Tag")
                        .WithMany("TagToBlog")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Blog");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.TagToBook", b =>
                {
                    b.HasOne("RefHub_EFCore_Sample.Database.Model.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RefHub_EFCore_Sample.Database.Model.Tag", "Tag")
                        .WithMany("TagToBook")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.UserAddress", b =>
                {
                    b.HasOne("RefHub_EFCore_Sample.Database.Model.User", "User")
                        .WithMany("UserAddress")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.UserToRole", b =>
                {
                    b.HasOne("RefHub_EFCore_Sample.Database.Model.Role", "Role")
                        .WithMany("UserToRole")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RefHub_EFCore_Sample.Database.Model.User", "User")
                        .WithMany("UserToRole")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.Another", b =>
                {
                    b.Navigation("BookToAnother");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.Blog", b =>
                {
                    b.Navigation("CommentToBlog");

                    b.Navigation("FileToBlog");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.Book", b =>
                {
                    b.Navigation("Another");

                    b.Navigation("CommentToBook");

                    b.Navigation("FileToBook");

                    b.Navigation("OrderItem");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.Category", b =>
                {
                    b.Navigation("Blog");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.FileManager", b =>
                {
                    b.Navigation("FileToBlog");

                    b.Navigation("FileToBook");

                    b.Navigation("FileToUser");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.Language", b =>
                {
                    b.Navigation("Blog");

                    b.Navigation("Book");

                    b.Navigation("Category");

                    b.Navigation("PersonLevel");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.Order", b =>
                {
                    b.Navigation("OrderItem");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.PersonLevel", b =>
                {
                    b.Navigation("Book");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.Role", b =>
                {
                    b.Navigation("UserToRole");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.Tag", b =>
                {
                    b.Navigation("TagToBlog");

                    b.Navigation("TagToBook");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.User", b =>
                {
                    b.Navigation("FileToUser");

                    b.Navigation("Order");

                    b.Navigation("UserAddress");

                    b.Navigation("UserToRole");
                });

            modelBuilder.Entity("RefHub_EFCore_Sample.Database.Model.UserAddress", b =>
                {
                    b.Navigation("Order");
                });
#pragma warning restore 612, 618
        }
    }
}
