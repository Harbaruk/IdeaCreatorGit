using IdeaCreator.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdeaCreator.Models
{
    public class UserViewModel
    {
        public IEnumerable<User> Users { get; set; }
    }
}