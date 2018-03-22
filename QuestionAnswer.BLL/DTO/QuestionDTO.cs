using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionAnswer.BLL.DTO
{
    public class QuestionDTO
    {
        public int SurveyId { get; set; }
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public int AnswerTypeId { get; set; }
        public string AnswerTypeText { get; set; }
        public List<VariantsOfAnswersDTO> VariantsOfAnswersDTO { get; set; }
    }
}
