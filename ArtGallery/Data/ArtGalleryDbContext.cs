using ArtGallery.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGallery.Data
{
    public class ArtGalleryDbContext : DbContext
    {
        public ArtGalleryDbContext(DbContextOptions<ArtGalleryDbContext> options) : base(options)
        { }

        public DbSet<ArtModel> ArtModels { get; set; }

        public DbSet<Comment> Comments { get; set; }

    }

}
