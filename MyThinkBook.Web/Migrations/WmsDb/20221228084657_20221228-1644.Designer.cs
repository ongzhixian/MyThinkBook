// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyThinkBook.Web.Data;

#nullable disable

namespace MyThinkBook.Web.Migrations.WmsDb
{
    [DbContext(typeof(WmsDbContext))]
    [Migration("20221228084657_20221228-1644")]
    partial class _202212281644
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("MyThinkBook.Domain.Wms.Client", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("client_pk");

                    b.ToTable("client", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
