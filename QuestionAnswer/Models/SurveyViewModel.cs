using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace QuestionAnswer.Models
{
    public class SurveyViewModel
    {
        public int SurveyId { get; set; }
        public string SurveyTitle { get; set; }

        [Display(Name ="Survey Type")]
        public int SurveyTypeId { get; set; }
        
        public string SurveyTypeName { get; set; }
    }
}