using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using PositiveBussinesModel.Files;
using PositiveBussinesModel.Members;
using PositiveWeb.Models.DatabaseLayer;
using PositiveBussinesModel.Content.PublishingItems;
using PositiveBussinesModel.Social;

namespace PositiveWeb.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        private PositiveRepositories personRepository = new PositiveRepositories(); 
        public ActionResult Index()
        {
            User myuser = personRepository.Users.ToList().First();
            return View(myuser);
        }


        public ActionResult SaveUser(User user)
        {
            User usertd = personRepository.Users.Find(user.UserId);
            usertd.Nume = user.Nume;
            usertd.Prenume = user.Prenume;
            personRepository.SaveChanges();
            return Json(usertd);
        }
            
        public string AddArticle()
        {
            var serializerSettings = new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects };
            User user = personRepository.Users.First();
            var article = new Article();
            article.ArticleId= Guid.NewGuid();
            article.Content = "SAlutare sakutare this is the best of the best in all countries";
            article.CreatedDate = DateTime.Now;
            article.Description = "An article about pusies;";
            article.Name = "Testing disabilities";
            article.IsFeatured = true;
            article.Users.Add(user);
            article.Documents.Add(new File() {Description = "salutare", Id = Guid.NewGuid(),Title = "pizdos"});
            article.Comments.Add(new Comment()
            {
                CommentContent = "esti un prost",
                CreatedDate = DateTime.Now,
                Id = Guid.NewGuid(),
                Title = "CE ORB esti pula",
                User = user
            });
            personRepository.Articles.Add(article);
            personRepository.SaveChanges();
            string json = JsonConvert.SerializeObject(article, Formatting.Indented, serializerSettings);
            return json;
        }

        public string GetArticleUsers()
        {
            var serializerSettings = new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects };

            var user = personRepository.Articles.First().Users.First();
            string json = JsonConvert.SerializeObject(user, Formatting.Indented, serializerSettings);
           
            return json;
        }

        public string GetComments()
        {
            var serializerSettings = new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects };

            var user = personRepository.Articles.Find(Guid.Parse("{5c315287-9f8b-4b8f-a56b-6ec89314031a}")).Comments.First();
            string json = JsonConvert.SerializeObject(user, Formatting.Indented, serializerSettings);

            return json;
        }


        public JsonResult CreateUser()
        {
            var user = new User() {UserId = Guid.NewGuid(), Description = "salut", Nume = "mihai", Prenume = "radulescu",BirthDate = DateTime.Now};
            personRepository.Users.Add(user);
            personRepository.SaveChanges();
            return Json(user, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Persons()
        {
            var person = personRepository.Users.ToList();
            return Json(person,JsonRequestBehavior.AllowGet);
        }

    }
}
