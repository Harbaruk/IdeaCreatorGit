using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdeaCreator.Models.Entities
{
    public class Idea
    {
        public int ID { get; set; }
        public string Caption { get; set; }
        public int UserID { get; set; }
        public int VotingID { get; set; }
        public string Description { get; set; }
    }
}