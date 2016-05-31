using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdeaCreator.Models.Entities
{
    public class Voting
    {
        public int ID { get; set; }
        public int IdeaID { get; set; }
        public int PlusCount { get; set; }
        public int MinusCount { get; set; }
        public string Caption { get; set; }
    }
}