namespace BlogSystem.Controllers
{
    using BlogSystem.Models;
    using Microsoft.AspNet.Identity;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class ArticleController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            using (var db = new BlogDbContext())
            {
                var articles = db.Articles
                    .Include(a => a.Author)
                    .ToList();
                
                return View(articles);
            }
        }

        // GET: Article
        [Authorize]
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(Article article)
        {
            if (ModelState.IsValid)
            {
                using (var db = new BlogDbContext())
                {
                    //Get author id
                    var authorId = User.Identity.GetUserId();

                    //Set articles author
                    article.AuthorId = authorId;

                    //Save articles in DB
                    db.Articles.Add(article);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }

            }

            return View(article);
        }

        public ActionResult Details(int? id)
        {
            using (var db  = new BlogDbContext())
            {
                var article = db.Articles
                    .Include(a => a.Author)
                    .Where(a => a.Id == id)
                    .FirstOrDefault();

                if (article == null)
                {
                    return HttpNotFound();
                }

                return View(article);
            }
        }

        [Authorize]
        [HttpGet]
        public ActionResult Delete(int id)
        {
            using (var db = new BlogDbContext())
            {
                var article = db.Articles  // .find(id)
                    .Where(a => a.Id == id)
                    .Include(a => a.Author)
                    .First();

                if (article == null || !IsAuthorized(article))
                {
                    return HttpNotFound();
                }

                return View(article);
            }
        }

        [Authorize]
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult ConfirmDelete(int id)
        {
            using (var db = new BlogDbContext())
            {
                var article = db.Articles   //.find(id)
                    .Where(a => a.Id == id)
                    .Include(a => a.Author)
                    .First();

                if (article == null || !IsAuthorized(article))
                {
                    return HttpNotFound();
                }

                db.Articles.Remove(article);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }

        [Authorize]
        [HttpGet]
        public ActionResult Edit (int id)
        {
            using (var db = new BlogDbContext())
            {
                var article = db.Articles
                    .Find(id);

                if (article == null || !IsAuthorized(article))
                {
                    return HttpNotFound();
                }

                var articleViewModel = new ArticleViewModel
                {
                    Id = article.Id,
                    Title = article.Title,
                    Content = article.Content,
                    AuthorId = article.AuthorId
                };

                return View(articleViewModel);
            }
        }

        [Authorize]
        [HttpPost]
        public ActionResult Edit (ArticleViewModel model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new BlogDbContext())
                {
                    var article = db.Articles
                    .Find(model.Id);

                    if (article == null || !IsAuthorized(article))
                    {
                        return HttpNotFound();
                    }

                    article.Title = model.Title;
                    article.Content = model.Content;

                    db.SaveChanges();
                }

                return RedirectToAction("Details", new { id = model.Id });
            }

            return View(model);
        }

        private bool IsAuthorized(Article article)
        {
            var isAdmin = this.User.IsInRole("Admin");
            var isAuthor = article.IsAuthor(this.User.Identity.GetUserId());

            return isAdmin || isAuthor;
        }
    }
}