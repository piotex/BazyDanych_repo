﻿using Microsoft.EntityFrameworkCore;
using System.IO;
using WebAppServer.Models;

namespace WebAppServer.Contexts
{
    public class OracleDbContext : DbContext
    {
        public OracleDbContext(DbContextOptions<OracleDbContext> options) : base(options) { }
        public OracleDbContext() : base() { }

        public virtual DbSet<UserCategory> UserCategory { get; set; }
        public virtual DbSet<Palet> Palet { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<TypeOfCare> TypeOfCare { get; set; }
        public virtual DbSet<PaletPlantsType> PaletPlantsType { get; set; }
        public virtual DbSet<CareSchedule> CareSchedule { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<ActualTask> ActualTask { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = @"C:\Users\pkubo\OneDrive\Dokumenty\GitHub\_Keys\oracle_db_ConnectionString.txt";

            optionsBuilder.UseOracle(File.ReadAllText(path));
        }
    }
}