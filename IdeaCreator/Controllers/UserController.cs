using IdeaCreator.Models;
using IdeaCreator.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IdeaCreator.Controllers
{
    //[Authorize(Roles="Admin")]
    public class UserController : Controller
    {
        private IUserRepository repository;

        public UserController(IUserRepository repo)
        {
            repository = repo;
        }

        public ViewResult Users()
       {
            UserViewModel model = new UserViewModel
            {
                Users = repository.Users.Where(x=>x.ID!=0).Take(5)
            };
            
            return View(model);
        }
	}
}