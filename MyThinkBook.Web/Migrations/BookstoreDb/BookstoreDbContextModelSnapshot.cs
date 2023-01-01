﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyThinkBook.Web.Data;

#nullable disable

namespace MyThinkBook.Web.Migrations.BookstoreDb
{
    [DbContext(typeof(BookstoreDbContext))]
    partial class BookstoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("MyThinkBook.Web.Data.BookstoreAuthor", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("last_name");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("middle_name");

                    b.HasKey("Id")
                        .HasName("author_pk");

                    b.ToTable("author", (string)null);
                });

            modelBuilder.Entity("MyThinkBook.Web.Data.BookstoreBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<int?>("BookstoreAuthorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Format")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("format");

                    b.Property<string>("InternationalStandardBookNumber")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("isbn");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("book_pk");

                    b.HasIndex("BookstoreAuthorId");

                    b.ToTable("book", (string)null);
                });

            modelBuilder.Entity("MyThinkBook.Web.Data.BookstoreAuthor", b =>
                {
                    b.HasOne("MyThinkBook.Web.Data.BookstoreBook", null)
                        .WithMany("Authors")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("book__author_fk");
                });

            modelBuilder.Entity("MyThinkBook.Web.Data.BookstoreBook", b =>
                {
                    b.HasOne("MyThinkBook.Web.Data.BookstoreAuthor", null)
                        .WithMany("Books")
                        .HasForeignKey("BookstoreAuthorId")
                        .HasConstraintName("author__book_fk");
                });

            modelBuilder.Entity("MyThinkBook.Web.Data.BookstoreAuthor", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("MyThinkBook.Web.Data.BookstoreBook", b =>
                {
                    b.Navigation("Authors");
                });
#pragma warning restore 612, 618
        }
    }
}
