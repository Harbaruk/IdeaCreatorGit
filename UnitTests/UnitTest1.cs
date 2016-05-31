using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using IdeaCreator.Models.Abstract;
using IdeaCreator.Models.Entities;
using System.Collections.Generic;
using IdeaCreator.Controllers;
using IdeaCreator.Models.ViewModels;
using System.Linq;
using System.Web.Mvc;
using IdeaCreator.HtmlHelpers;
using IdeaCreator.Models;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Paginate()
        {
            Mock<IIdeasRepository> mock = new Mock<IIdeasRepository>();
            mock.Setup(m => m.Ideas).Returns(new List<Idea>
                {
                    new Idea {ID = 1, Caption = "1", Description = "1", UserID = 1, VotingID = 1},
                    new Idea {ID = 2, Caption = "2", Description = "1", UserID = 2, VotingID = 2},
                    new Idea {ID = 3, Caption = "3", Description = "1", UserID = 2, VotingID = 3},
                    new Idea {ID = 4, Caption = "4", Description = "1", UserID = 3, VotingID = 4},
                    new Idea {ID = 5, Caption = "5", Description = "1", UserID = 4, VotingID = 5},
                    new Idea {ID = 6, Caption = "6", Description = "1", UserID = 1, VotingID = 6},
                });

            IdeaController controller = new IdeaController(mock.Object);
            controller.pageSize = 3;

            ////Дія
            IdeaViewModel result = (IdeaViewModel)controller.Ideas(2).Model;

            ////Ствердження
            List<Idea> themes = result.Ideas.ToList();

            Assert.IsTrue(themes.Count == 3);
            Assert.AreEqual(themes[0].Caption, "4");
            Assert.AreEqual(themes[1].Caption, "5");
        }


        [TestMethod]
        public void Can_Get_Links()
        {
            HtmlHelper myHelper = null;
            PagingInfo paginginfo = new PagingInfo
            {
                CurrentPage = 2,
                TotalItems = 28,
                ItemsPerPage = 10
            };

            Func<int, string> pageUrlDelegate = i => "Page" + i;

            MvcHtmlString result = myHelper.PageLinks(paginginfo, pageUrlDelegate);

            Assert.AreEqual(@"<a class=""btn btn-default"" href=""Page1"">1</a>" +
                @"<a class=""btn btn-default btn-primary selected"" href=""Page2"">2</a>" +
            @"<a class=""btn btn-default"" href=""Page3"">3</a>", result.ToString());
        }

    }
}
