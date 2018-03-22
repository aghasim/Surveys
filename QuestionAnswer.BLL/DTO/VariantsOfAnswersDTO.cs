using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionAnswer.BLL.DTO
{
    public class VariantsOfAnswersDTO
    {
        public int Id { get; set; }
        public int Questionid { get; set; }
        public string AnswerText { get; set; }
    }
}
