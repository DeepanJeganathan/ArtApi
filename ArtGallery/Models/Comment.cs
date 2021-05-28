using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGallery.Models
{
    public class Comment
    {
        public int CommentId { get; set; }

        [Required]
        [StringLength (50)]
        public string Name { get; set; }

        [Required]
        [MinLength(10)]
        public string  Post { get; set; }

        public DateTime Date { get; set; }

        public double ArtModelId { get; set; }
        public ArtModel ArtModel { get; set; }
    }
}
