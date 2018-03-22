using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestionAnswer.Models
{
    public class PercentageAnswersViewModel
    {
        public int SurveyTypeId { get; set; }
        public string SurveyTypeText { get; set; }
        public int AnswerTypeId { get; set; }
        public string AnswerTypetext { get; set; }
        public double Percentage { get; set; }
    }
}