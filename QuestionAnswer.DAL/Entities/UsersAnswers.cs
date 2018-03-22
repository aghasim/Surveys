using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionAnswer.DAL.Entities
{
    public class UsersAnswers
    {
        [Key]
        public int Id { get; set; }
        public int SurveyTypeId { get; set; }
        public int SurveyId { get; set; }
        public int QuestionId { get; set; }
        public int AnswerTypeId { get; set; }
        public int VariantsOfAnswerId { get; set; }
        public string Answer { get; set; }
    }
}
