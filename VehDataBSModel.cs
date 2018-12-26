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
                entity.HasKey(e => e.VehCategs) //Primary Key, Lamda statement
                      .HasName("PK_VehicInfos");

                //This how autogenterate a property or column

                entity.Property(e => e.VehCategs)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Make)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.ToTable("VehicInfos"); //Names the table
            });
             
        }
    }
}
