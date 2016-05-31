using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IdeaCreator.Models.Abstract;
using IdeaCreator.Models.Entities;

namespace IdeaCreator.Models.Concrete
{
    public class CommentRepository : ICommentRepository
    {
        EFContext context = new EFContext();

        public IEnumerable<Comment> Comments
        {
            get { return context.Comments; }
        }
    }
}