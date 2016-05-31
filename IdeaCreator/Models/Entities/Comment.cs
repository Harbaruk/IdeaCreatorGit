using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdeaCreator.Models.Entities
{
    public class Comment
    {
        public int ID { get; set; }
        public int IdeaID { get; set; }
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Description { get; set; }
    }
}