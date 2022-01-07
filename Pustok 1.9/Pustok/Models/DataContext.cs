﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pustok.Models
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<AppUser> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<PromotionBottom> BottomPromotions { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Feature> Features { get; set; }

    }
}