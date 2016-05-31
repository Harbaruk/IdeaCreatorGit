using IdeaCreator.Models.Concrete;
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

        public static string GetAuthor(int ID)
        {
            string res;

            EFContext cont = new EFContext();
            res = cont.Users.Where(x => x.ID == ID).ToList()[0].Username;

            return res;
        }

        public static string GetPluses(int ID)
        {
            EFContext cont = new EFContext();

            int res = 0;
            int temp = cont.Ideas.Where(x => x.ID == ID).ToList()[0].VotingID;
            res = cont.Votings.Where(x => x.ID == temp).ToList()[0].PlusCount;
            

            return res.ToString();
        }

        public static string GetMinus(int ID)
        {
            EFContext cont = new EFContext();

            int res = 0;
            int temp = cont.Ideas.Where(x => x.ID == ID).ToList()[0].VotingID;
            res = cont.Votings.Where(x => x.ID == temp).ToList()[0].MinusCount;


            return res.ToString();
        }

        public static List<Comment> GetComments(int ID)
        {
            EFContext context = new EFContext();

            return context.Comments.Where(x => x.IdeaID == ID).ToList();
           
        }
    }
}