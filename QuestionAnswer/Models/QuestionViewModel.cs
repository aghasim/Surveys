using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace QuestionAnswer.Models
{
    public class QuestionViewModel
    {
        public int SurveyId { get; set; }
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public int AnswerTypeId { get; set; }
        public string AnswerTypeText { get; set; }
        public List<VariantsOfAnswersViewModel> VariantsOfAnswersViewModel { get; set; }
    }
}