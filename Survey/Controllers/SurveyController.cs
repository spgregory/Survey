using Survey.Models;
using Survey.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Survey.Controllers
{
    public class SurveyController : Controller
    {
        List<Option> options = new List<Option>();
      List<Question> questions = new List<Question>();
        private ApplicationDbContext db;
        public SurveyController()
        {
            db = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
        // GET: Survey
        public ActionResult Index()
        {

            
            foreach(var item in db.Options)
            {
                options.Add(new Option {Id = item.Id, OptionOne=item.OptionOne,OptionTwo=item.OptionTwo,OptionThree=item.OptionThree,OptionFour=item.OptionFour,OptionOneValue=item.OptionOneValue,OptionTwoValue=item.OptionTwoValue,OptionThreeValue=item.OptionThreeValue,OptionFourValue=item.OptionFourValue });
            }
            
            foreach(var item in db.Questions)
            {
                questions.Add(new Question { Id = item.Id, QuestionText = item.QuestionText, Option_Name = item.Option_Name });
            }

            var option_name = new List<string>();
            foreach(var item in db.Questions)
            {
                var hold = item.Option_Name;

                option_name.Add(hold);
            }
            var survey = new SurveyVM()
            {
                Questions = questions,
                Options = options,
                OptionName = option_name
            };

           
            return View(survey);
        }
        public ActionResult SurveyResult(SurveyVM model)
        {
            for (var i = 0; i < model.Options.Count; i++)
            {
                if (model.Questions[i].Option_Name.Equals(model.Options[i].OptionOne))
                    model.Options[i].OptionOneValue += 1;

                if (model.Questions[i].Option_Name.Equals(model.Options[i].OptionTwo))
                    model.Options[i].OptionTwoValue += 1;

                if (model.Questions[i].Option_Name.Equals(model.Options[i].OptionThree))
                    model.Options[i].OptionThreeValue += 1;

                if (model.Questions[i].Option_Name.Equals(model.Options[i].OptionFour))
                    model.Options[i].OptionFourValue += 1;

                var OptionInDb = db.Options.Find(i+1);
                OptionInDb.OptionOne = model.Options[i].OptionOne;
                OptionInDb.OptionOneValue = model.Options[i].OptionOneValue;
                OptionInDb.OptionTwo = model.Options[i].OptionTwo;
                OptionInDb.OptionTwoValue = model.Options[i].OptionTwoValue;
                OptionInDb.OptionThree = model.Options[i].OptionThree;
                OptionInDb.OptionThreeValue = model.Options[i].OptionThreeValue;
                OptionInDb.OptionFour = model.Options[i].OptionFour;
                OptionInDb.OptionFourValue = model.Options[i].OptionFourValue;
                db.SaveChanges();


            }

            return View(model);
        }
    }
}