using ArtGallery.Data;
using ArtGallery.Models;
using ArtGallery.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGallery.Repository
{
    public class CommentRepository : IComment
    {
        private readonly ArtGalleryDbContext _context;

        public CommentRepository(ArtGalleryDbContext context)
        {
            this._context = context;
        }
        public bool CommentExists(int id)
        {
            return _context.Comments.Any(x => x.CommentId == id);
        }

        public bool CreateComment(Comment comment)
        {
            _context.Comments.Add(comment);
            return save();

        }

        public bool DeleteComment(Comment comment)
        {
            _context.Comments.Remove(comment);
            return save();
        }

        public List<Comment> Get(int artId)
        {
            return _context.Comments.Where(x=>x.ArtModelId==artId).ToList();
        }

        public List<Comment> GetAll()
        {
            return _context.Comments.ToList();
        }

        public Comment GetById(int id)
        {
            return _context.Comments.FirstOrDefault(x => x.CommentId == id);
        }

        public bool save()
        {
            return _context.SaveChanges() >= 0 ? true : false; 
        }
    }
}
