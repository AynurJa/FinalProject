using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagicHome.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MagicHome.DAL
{
    public class AppDbContext:IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }

        public DbSet <City> Cities{ get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Message> Messages { get; set; }
       // public DbSet<User> Users { get; set; }
        public DbSet<AdvertType> AdvertTypes { get; set; }
        public DbSet<Advert> Adverts { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
