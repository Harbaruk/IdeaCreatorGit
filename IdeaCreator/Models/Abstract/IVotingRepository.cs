using IdeaCreator.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeaCreator.Models.Abstract
{
    public interface IVotingRepository
    {
        IEnumerable<Voting> Votings { get;  }
    }
}
