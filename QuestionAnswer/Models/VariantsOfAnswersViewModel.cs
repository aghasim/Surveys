using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestionAnswer.Models
{
    public class VariantsOfAnswersViewModel
    {
        public int Id { get; set; }
        public int Questionid { get; set; }
        public string AnswerText { get; set; }
    }
}