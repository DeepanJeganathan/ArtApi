using ArtGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGallery.Service
{
    public interface IArt
    {

        IList<ArtModel> GetAll(ArtParameters artParameters,string search);

        int Count();
    }
}
