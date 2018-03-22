using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionAnswer.BLL.DTO
{
    public class UsersAnswersDTO
    {
        public int SurveyTypeId { get; set; }
        public int SurveyId { get; set; }
        public int QuestionId { get; set; }
        public int AnswerTypeId { get; set; }
        public int VariantsOfAnswerId { get; set; }
        public string Answer { get; set; }
    }
}
