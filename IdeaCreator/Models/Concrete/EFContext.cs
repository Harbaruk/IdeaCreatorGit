using IdeaCreator.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IdeaCreator.Models.Concrete
{
    public class EFContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Idea> Ideas { get; set; }
        public DbSet<Voting> Votings { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}