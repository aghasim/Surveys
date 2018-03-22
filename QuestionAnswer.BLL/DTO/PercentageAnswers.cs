using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionAnswer.BLL.DTO
{
    public class PercentageAnswers
    {
        public int SurveyTypeId { get; set; }
        public string SurveyTypeText { get; set; }
        public int AnswerTypeId { get; set; }
        public string AnswerTypetext { get; set; }
        public double Percentage { get; set; }
    }
}
