using Survey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace Survey.ViewModel
{
    public class SurveyVM
    {
        public virtual List<Option> Options { get; set; }
        public virtual List<Question> Questions { get; set; }
        public virtual List<string> OptionName { get; set; }
        public Option Option { get; set; }
        public Question Question { get; set; }


    }
}