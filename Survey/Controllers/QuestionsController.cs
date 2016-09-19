using Survey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Survey.ViewModel;

namespace Survey.Controllers
{
    public class QuestionsController : Controller
    {
        private ApplicationDbContext db;
        public QuestionsController()
        {
            db = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
        // GET: Questions
        public ActionResult Index()
        {

            var questions = db.Questions.ToList();
            return View(questions);
        }

        public ActionResult Edit(int id)
        {
            var question = db.Questions.SingleOrDefault(q => q.Id == id);
            var option = db.Options.SingleOrDefault(o => o.Id == question.Id);

            var survey = new SurveyVM()
            {
                Question = question,
                Option = option
            };

            if (question == null)
                return HttpNotFound();
            return View("QuestionForm", survey);
        }

        public ActionResult Save(SurveyVM model)
        {
            return View();
        }
    }
}