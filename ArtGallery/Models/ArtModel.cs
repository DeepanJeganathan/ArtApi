using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGallery.Models
{
    public class ArtModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public double ArtModelId { get; set; }
        public double FID { get; set; }
        public string Source { get; set; }
        public string Location { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public string Medium { get; set; }
        public string ArtForm { get; set; }
        public string Status { get; set; }
        public string ImageName { get; set; }
        public string ImageURL { get; set; }
        public string ThumbURL { get; set; }
        public string ImageAltText { get; set; }
        public double LONG { get; set; }
        public string LAT { get; set; }
        public double WARD { get; set; }
        public string WARD_FULLNAME { get; set; }
        public double YEAR_INSTALLED { get; set; }
        public string Description { get; set; }
        public string OwnedBy { get; set; }
        public string CommissionedBy { get; set; }
        public string PublicArtConsultant { get; set; }
        public string ImageOrientation { get; set; }
        public string ExternalLink { get; set; }
        public string ExternalLinkText { get; set; }
        public double FID2 { get; set; }
        public string geometry { get; set; }
        public ICollection<Comment> comments { get; set; }
    }
}
