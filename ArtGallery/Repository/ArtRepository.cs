using ArtGallery.Data;
using ArtGallery.Models;
using ArtGallery.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGallery.Repository
{
    public class ArtRepository : IArt
    {
        private readonly ArtGalleryDbContext _artGalleryDbContext;

        public ArtRepository(ArtGalleryDbContext artGalleryDbContext)
        {
            this._artGalleryDbContext = artGalleryDbContext;
        }

        public IList<ArtModel> GetAll()
        {
            return _artGalleryDbContext.ArtModels.Take(10).ToList();
        }
    }
}
