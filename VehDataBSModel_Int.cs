using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace VehicalApp
{
    class VehDataBSModel : DbContext

    {

        //Defining tables for your schema or properties

        public virtual DbSet<VehicInfo> VehicInfos { get; set; }
        public virtual DbSet<VehRelation> VehRelations { get; set; } 
        //Virtual method allows tables to be modified



        //Override implies to changing the behavior of the parents class, inheritance

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {

            //We have to tell the program where to store the database

            

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VehDb;Integrated Security=True;Connect Timeout=30;");

        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            //Purpose is to tell EnityFrameWork how to create the table

            modelBuilder.Entity<VehicInfo>(entity =>

            {

                entity.HasKey(e => e.Cselect) //Primary Key, Lamda statement

                      .HasName("PK_VehicInfos");

                //This how autogenterate a property or column

                entity.Property(e => e.Cselect)

                    .ValueGeneratedOnAdd();


                entity.Property(e => e.CusName)

                    .IsRequired()

                    .HasMaxLength(25);

                entity.HasMany(e => e.VehRelations);

                entity.ToTable("VehicInfos"); //Names the table

            });

            modelBuilder.Entity<VehRelation>(entity =>

            {

                entity.HasKey(e => e.CusRecord) //Primary Key, Lamda statement

                      .HasName("PK_VehRelations");

                //This how autogenterate a property or column

                entity.Property(e => e.CusRecord)

                    .ValueGeneratedOnAdd();


                entity.HasOne(e => e.VehicInfo);

                   


                entity.ToTable("VehRelations"); //Names the table

            });

        }

    }

}

