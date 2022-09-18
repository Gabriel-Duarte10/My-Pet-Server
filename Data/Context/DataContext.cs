using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using My_Pet.Models;

namespace My_Pet.Data.Context
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<Adoption> Adoption { get; set; }
        public DbSet<AdoptionImage> AdoptionImage { get; set; }
        public DbSet<Lost> Lost { get; set; }
        public DbSet<LostImage> LostImage { get; set; }
        public DbSet<Reproduction> Reproduction { get; set; }
        public DbSet<ReproductionImage> ReproductionImage { get; set; }
        public DbSet<Rescue> Rescue { get; set; }
        public DbSet<RescueImage> RescueImage { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<SaleImage> SaleImage { get; set; }
        public DbSet<Announcement> Announcement { get; set; }
        public DbSet<AnnouncementImage> AnnouncementImage { get; set; }
        public DbSet<User> User { get; set; }
         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
  
            modelBuilder.Entity<AdoptionImage>()
                .HasKey(x => new {x.id, x.nameImageFireBase, x.urlImageFireBase});
            modelBuilder.Entity<LostImage>()
                .HasKey(x => new {x.id, x.nameImageFireBase, x.urlImageFireBase});
            modelBuilder.Entity<ReproductionImage>()
                .HasKey(x => new {x.id, x.nameImageFireBase, x.urlImageFireBase});
            modelBuilder.Entity<RescueImage>()
                .HasKey(x => new {x.id, x.nameImageFireBase, x.urlImageFireBase});
            modelBuilder.Entity<SaleImage>()
                .HasKey(x => new {x.id, x.nameImageFireBase, x.urlImageFireBase});
            modelBuilder.Entity<AnnouncementImage>()
                .HasKey(x => new {x.id, x.nameImageFireBase, x.urlImageFireBase});          
        }
    }
}