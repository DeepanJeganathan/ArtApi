using ArtGallery.Data;
using ArtGallery.DTOs;
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

        public int Count()
        {
            return _artGalleryDbContext.ArtModels.Count();
        }

        public IList<ArtModel> GetAll(ArtParameters artParameters, string search)
        {
            

            if (string.IsNullOrEmpty(search))

            {
                return _artGalleryDbContext.ArtModels.Skip((artParameters.PageNumber - 1) * (artParameters.PageSize)).Take(artParameters.PageSize).ToList();
              
            }
            return _artGalleryDbContext.ArtModels.Where(x=>x.Title.Contains(search)).Skip((artParameters.PageNumber - 1) * (artParameters.PageSize)).Take(artParameters.PageSize).ToList();

        }
    }
}
