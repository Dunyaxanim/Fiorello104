using Fiorello.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.DAL
{
    public class AppDbContext:DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> option):base(option)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SlidersData> SlidersDatas { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<AboutList> AboutLists { get; set; }
        public DbSet<FlowerExpert> FlowerExperts { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SlidersData>().HasData(new SlidersData
            {
                Id = 1,
                SubTitle = "Where flowers are our inspiration to create lasting memories. Whatever the occasion, our flowers will make it special cursus a sit amet mauris.",
                Title = "<h1>Send <span>flowers </span> like</h1> <h1> you mean it </h1> ",
                Name = "h2-sign-img.png"
            });
            modelBuilder.Entity<About>().HasData(new About
            {
                Id = 1,
                Title = " <h1>Suprise Your <span>Valentine!</span> Let us arrange a smile.</h1>",
                Subtitle = "Where flowers are our inspiration to create lasting memories. Whatever the occasion...",
                Imgurl = "h2-sign-img.png"
            });
        }
    } 
   
}
