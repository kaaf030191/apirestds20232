﻿using _5._0.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace _5._0.DataAccessLayer.Connection
{
    public class DataBaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DataBaseContext()
        {
            InitAutoMapper.start();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("tuser");

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=KAAF-PC\\SQLEXPRESS;Database=dbcrud20232;User Id=sa;Password=030191;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}