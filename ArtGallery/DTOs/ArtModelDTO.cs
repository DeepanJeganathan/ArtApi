using ArtGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGallery.DTOs
{
    public class ArtModelDTO
    {
        public List<ArtModel> artModels { get; set; }
        public int TotalCount { get; set; }


    }
}
