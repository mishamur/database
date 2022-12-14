// <auto-generated />
using DbApi;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DbApi.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20221122201013_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("DbApi.Models.Bonus", b =>
                {
                    b.Property<string>("BonusName")
                        .HasColumnType("TEXT");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.HasKey("BonusName");

                    b.ToTable("Bonuses");
                });

            modelBuilder.Entity("DbApi.Models.Projectile", b =>
                {
                    b.Property<string>("ProjectileName")
                        .HasColumnType("TEXT");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProjectileName");

                    b.ToTable("Projectiles");
                });

            modelBuilder.Entity("DbApi.Models.Stat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DefenceLevel")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Hp")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MovespeedLevel")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Stats");
                });
#pragma warning restore 612, 618
        }
    }
}
