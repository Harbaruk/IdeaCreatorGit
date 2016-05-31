using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IdeaCreator.Models.Abstract;
using IdeaCreator.Models.Entities;

namespace IdeaCreator.Models.Concrete
{
    public class VotingRepository : IVotingRepository
    {
        
            EFContext context = new EFContext();

            public IEnumerable<Voting> Votings
            {
                get { return context.Votings; }
            }
     }
}