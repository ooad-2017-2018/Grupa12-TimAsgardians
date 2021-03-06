﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProjekatAsgardiansNet.Models
{
    public class AsgardiansContext : DbContext
    {
        
        public AsgardiansContext() : base("AzureBaza") {}
        //dodavanjem klasa iz modela kao DbSet iste će biti mapirane u bazu podataka
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Lokacija> Lokacija { get; set; }
        public DbSet<Putnik> Putnik { get; set; }
        public DbSet<Uposlenik> Uposlenik { get; set; }
        public DbSet<Vodic> Vodic { get; set; }
        //Ova funkcija se koriste da bi se ukinulo automatsko dodavanje množine u nazive
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        
    }
}