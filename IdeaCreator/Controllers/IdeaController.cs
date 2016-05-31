using IdeaCreator.Models;
using IdeaCreator.Models.Abstract;
using IdeaCreator.Models.Concrete;
using IdeaCreator.Models.Entities;
using IdeaCreator.Models.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace IdeaCreator.Controllers
{
    public class IdeaController : Controller
    { 
        private IIdeasRepository repository;
        public int pageSize = 4;
        public IdeaController(IIdeasRepository repo)
        {
            repository = repo;
        }

        public ViewResult Ideas(int page = 1)
        {
            IdeaViewModel model = new IdeaViewModel
            {
                Ideas = repository.Ideas
                .OrderBy(idea => idea.ID)
                .Skip((page - 1) * pageSize)
                .Take(pageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = repository.Ideas.Count()
                }
            };

            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> Ideas()
        {
            return RedirectToAction("Add", "Idea");
        }

        public ViewResult Show(string id)
        {
            string a = id;

            IdeaViewModel model = new IdeaViewModel
            {
                Ideas = repository.Ideas
            };

            Idea res = model.Ideas.Where(x => x.ID == int.Parse(id)).First();


            return View(res);
        }

        public ActionResult Add()
        {
            IdeaAdditionModel a = new IdeaAdditionModel();
            if (User.Identity.IsAuthenticated == false)
            {
                return RedirectToAction("Login", "Account");
            }

            else
                return View();
       }

        
        [HttpPost]
        public async Task<ActionResult> Add(IdeaAdditionModel model)
        {
            
            EFContext cont = new EFContext();
            int a = cont.Users.Where(x=>x.Email==User.Identity.Name).ToList()[0].ID;
            if (ModelState.IsValid)
            {
                Idea res = new Idea
                {
                    Caption = model.Name,
                    Description = model.Description,
                    UserID = a,
                    VotingID = 1
                };
                
                cont.Ideas.Add(res);
                cont.SaveChanges();
            }

            return RedirectToAction("Ideas", "Idea");
            //return View(model);
        }
	}
}