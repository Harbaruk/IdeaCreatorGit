using IdeaCreator.Models.Abstract;
using IdeaCreator.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdeaCreator.Models.Concrete
{
    public class UserRepository : IUserRepository
    {
        EFContext context = new EFContext();

        public IEnumerable<User> Users
        {
            get { return context.Users; }
        }
    }
}