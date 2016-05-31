using IdeaCreator.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdeaCreator.Models.Abstract
{
    public interface IUserRepository
    {
        IEnumerable<User> Users { get; }
    }
}