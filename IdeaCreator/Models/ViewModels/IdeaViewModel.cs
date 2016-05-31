using IdeaCreator.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdeaCreator.Models.ViewModels
{
    public class IdeaViewModel
    {
        public IEnumerable<Idea> Ideas { get; set; }

        public PagingInfo PagingInfo { get; set; }
    }
}