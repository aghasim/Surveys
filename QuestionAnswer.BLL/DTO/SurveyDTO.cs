using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionAnswer.BLL.DTO
{
    public class SurveyDTO
    {
        public int SurveyId { get; set; }
        public string SurveyTitle { get; set; }
        public int SurveyTypeId { get; set; }
        public string SurveyTypeName { get; set; }
    }
}
