using ArtGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGallery.Service
{
    public interface IComment
    {
        List<Comment> GetAll();
        List<Comment> Get(int id);
        Comment GetById(int id);
        bool CommentExists(int id);
        bool CreateComment(Comment comment);
        bool DeleteComment(Comment comment);
        bool save();

    }
}
