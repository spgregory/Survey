using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Survey.Models
{
    public class Option
    {
        public int Id { get; set; }

        public string OptionOne { get; set; }

        public string OptionTwo { get; set; }

        public string OptionThree { get; set; }

        public string OptionFour { get; set; }

        public int OptionOneValue { get; set; }

        public int OptionTwoValue { get; set; }

        public int OptionThreeValue { get; set; }

        public int OptionFourValue { get; set; }

    }
}
