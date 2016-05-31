using IdeaCreator.Models.Abstract;
using IdeaCreator.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdeaCreator.Models.Concrete
{
    public class IdeaRepository : IIdeasRepository
    {
        EFContext context = new EFContext();

        public IEnumerable<Idea> Ideas
        {
            get { return context.Ideas; }
        }
    }
}